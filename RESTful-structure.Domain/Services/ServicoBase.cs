using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using RESTfulstructure.Domain.Models;
using RESTfulstructure.Domain.Models.Enums;
using RESTfulstructure.Domain.Models.Exceptions;
using RESTfulstructure.Domain.Repositories;
using RESTfulstructure.Domain.Repositories.Queries;
using RESTfulstructure.Domain.ResourceDTO;
using RESTfulstructure.Domain.Services.Interfaces;

namespace RESTfulstructure.Domain.Services
{
    public abstract class ServicoBase<TEntidade, TRepository> : IServiceBase<TEntidade> where TEntidade : EntityBase where TRepository : IRepositorioBase<TEntidade>
    {
        protected readonly TRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMemoryCache _cache;

        public ServicoBase(
            TRepository repository,
            IUnitOfWork unitOfWork,
            IMemoryCache cache
        )
        {
            this._repository = repository;
            _unitOfWork = unitOfWork;
            _cache = cache;
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            // var existingCategory = await _repository.FindByIdAsync(entidade.Id);

            // #obs : validar
            bool retorno = await _repository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
            return retorno;
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public virtual async Task<TEntidade> SaveAsync(TEntidade entidade)
        {
            // #obs : validar

            entidade = await _repository.SaveAsync(entidade);

            // The Database Logic and the Unit of Work Pattern
            await _unitOfWork.CompleteAsync();

            return entidade;
        }

        public virtual async Task<QueryResult<TEntidade>> ListAsync(BaseQuery query)
        {
            // Here I try to get the categories list from the memory cache. If there is no data in cache, the anonymous method will be
            // called, setting the cache to expire one minute ahead and returning the Task that lists the categories from the repository.
            string cacheKey = GetCacheKeyForProductsQuery(query);

            var list = await _cache.GetOrCreateAsync(cacheKey, (entry) =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1);
                return _repository.ListAsync(query);
            });

            return list;
        }
        public virtual async Task<IEnumerable<TEntidade>> ListAsync()
        {
            // Here I try to get the categories list from the memory cache. If there is no data in cache, the anonymous method will be
            // called, setting the cache to expire one minute ahead and returning the Task that lists the categories from the repository.
            var categories = await _cache.GetOrCreateAsync(CacheKeys.CategoriesList, (entry) =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1);
                return _repository.ListAsync();
            });

            return categories;

            // return _repository.ListAsync();
        }

        public virtual async Task<TEntidade> FindByIdAsync(int id)
        {
            // var existingCategory = await _repository.FindByIdAsync(entidade.Id);

            // #obs : validar

            var existingCategory = await _repository.FindByIdAsync(id);
            return existingCategory;
        }

        public virtual async Task<TEntidade> UpdateAsync(TEntidade entidade)
        {
            // var existingCategory = await _repository.FindByIdAsync(entidade.Id);

            // #obs : validar

            entidade = await _repository.UpdateAsync(entidade);
            await _unitOfWork.CompleteAsync();
            return entidade;
        }

        private string GetCacheKeyForProductsQuery(BaseQuery query)
        {
            string key = CacheKeys.Base.ToString();

            if (query.id.HasValue && query.id > 0)
            {
                key = string.Concat(key, "_", query.id.Value);
            }

            key = string.Concat(key, "_", query.Page, "_", query.ItemsPerPage);
            return key;
        }
    }
}
