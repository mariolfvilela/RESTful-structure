using Microsoft.Extensions.Caching.Memory;
using RESTfulstructure.Domain.Models;
using RESTfulstructure.Domain.Repositories;
using RESTfulstructure.Domain.Services.Interfaces;

namespace RESTfulstructure.Domain.Services
{
    public class CategoryService : ServicoBase<Category, ICategoryRepository>, ICategoryService
    {
        public CategoryService(ICategoryRepository repositorio, IUnitOfWork unitOfWork, IMemoryCache cache)
           : base(repositorio, unitOfWork, cache)
        {
        }
    }
}