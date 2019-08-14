using System;
using System.Collections.Generic;

namespace RESTful_structure.Api.ResourceDTO
{
    public class QueryResultResource<T>
    {
        public int TotalItems { get; set; } = 0;
        public List<T> Items { get; set; } = new List<T>();
    }
}
