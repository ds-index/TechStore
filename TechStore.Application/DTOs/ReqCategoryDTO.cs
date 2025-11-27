using System.ComponentModel.DataAnnotations;

namespace TechStore.Application.DTOs
{
    public class ReqCategoryDTO
    {

        [Required]
        [MaxLength(50)]
        public string? CategoryName { get; set; }

        [Required]
        [MaxLength(200)]
        public string? CategoryDescription { get; set; }
    }
}
