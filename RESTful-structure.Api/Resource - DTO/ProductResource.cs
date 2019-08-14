namespace RESTful_structure.Api.ResourceDTO
{
    public class ProductResource : BaseResource
    {
        public string Name { get; set; }
        public int QuantityInPackage { get; set; }
        public string UnitOfMeasurement { get; set; }
        public CategoryResource Category { get; set; }
    }
}