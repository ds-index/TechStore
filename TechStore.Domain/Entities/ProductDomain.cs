using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore.Domain.Entities
{
    public class ProductDomain
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

        [ConcurrencyCheck]
        [Timestamp]
        public byte[] Version { get; set; }

        public bool IsDeleted { get; set; } = false;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public CategoryDomain? Category { get; set; }
    }
}
