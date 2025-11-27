using System.ComponentModel.DataAnnotations;

namespace TechStore.Application.DTOs
{
    public class ResProductDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? ProductName { get; set; }

        [Required]
        [MaxLength(200)]
        public string? ProductDescription { get; set; }

        [Required]
        [Range(1, 10_000)]
        public decimal Price { get; set; }

        [Required]
        [Range(1, 100)]
        public int Inventory { get; set; }
    }
}
