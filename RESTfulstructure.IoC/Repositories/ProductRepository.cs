using System;
using RESTfulstructure.Domain.Models;
using RESTfulstructure.Domain.Repositories;
using RESTfulstructure.Infra.Contexts;

namespace RESTfulstructure.Infra.Repositories
{
    public class ProductRepository : RepositorioBase<Product>, IProductRepository
    {
        public ProductRepository(Context contexto)
            : base(contexto)
        {
        }
    }
}
