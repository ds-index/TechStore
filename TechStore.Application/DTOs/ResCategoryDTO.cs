using System.ComponentModel.DataAnnotations;

namespace TechStore.Application.DTOs
{
    public class ResCategoryDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? CategoryName { get; set; }

        [Required]
        [MaxLength(200)]
        public string? CategoryDescription { get; set; }
    }
}
