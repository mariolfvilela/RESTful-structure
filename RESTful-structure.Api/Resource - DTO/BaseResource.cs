using System;
namespace RESTful_structure.Api.ResourceDTO
{
    public abstract class BaseResource
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
