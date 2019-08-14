using System.Collections.Generic;
using System.Threading.Tasks;
using RESTfulstructure.Domain.Models;
using RESTfulstructure.Domain.Repositories.Queries;

namespace RESTfulstructure.Domain.Repositories
{
    public interface IProductRepository : IRepositorioBase<Product>
    {
        Task<QueryResult<Product>> ListAsync(BaseQuery query);
    }
}