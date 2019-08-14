using System.Collections.Generic;

namespace RESTfulstructure.Domain.Repositories.Queries
{
    public class QueryResult<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int TotalItems { get; set; } = 0;
    }
}