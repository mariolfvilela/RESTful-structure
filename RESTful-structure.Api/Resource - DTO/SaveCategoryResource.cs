using System.ComponentModel.DataAnnotations;
namespace RESTful_structure.Api.ResourceDTO
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
