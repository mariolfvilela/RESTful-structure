using System;
namespace RESTful_structure.Api.ResourceDTO
{
    public class ProductsQueryResource : QueryResource
    {
        public int? CategoryId { get; set; }
    }
}
