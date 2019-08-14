using Microsoft.Extensions.Caching.Memory;
using RESTfulstructure.Domain.Models;
using RESTfulstructure.Domain.Repositories;
using RESTfulstructure.Domain.Services.Interfaces;

namespace RESTfulstructure.Domain.Services
{
    public class ProductService : ServicoBase<Product, IProductRepository>, IProductService
    {
        public ProductService(IProductRepository repositorio, IUnitOfWork unitOfWork, IMemoryCache cache)
           : base(repositorio, unitOfWork, cache)
        {
        }
    }
}