using System;
using RESTfulstructure.Domain.Models;
using RESTfulstructure.Domain.Repositories;
using RESTfulstructure.Infra.Contexts;

namespace RESTfulstructure.Infra.Repositories
{
    public sealed class CategoryRepository : RepositorioBase<Category>, ICategoryRepository
    {
        public CategoryRepository(Context contexto)
            : base(contexto)
        {
        }
    }
}
