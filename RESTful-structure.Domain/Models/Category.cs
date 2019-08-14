using System.Collections.Generic;

namespace RESTfulstructure.Domain.Models
{
    /// <summary>
    /// Entidade de Category.
    /// </summary>
    public class Category: EntityBase
    {
        public string Name { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}