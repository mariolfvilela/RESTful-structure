using System;
namespace RESTfulstructure.Domain.Repositories.Queries
{
    public class BaseQuery : Query
    {
        public int? id { get; set; }
        public BaseQuery(int? _id, int page, int itemsPerPage) : base(page, itemsPerPage)
        {
            id = _id;
        }
    }
}
