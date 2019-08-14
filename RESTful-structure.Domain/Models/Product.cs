using RESTfulstructure.Domain.Models.Enums;

namespace RESTfulstructure.Domain.Models
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}