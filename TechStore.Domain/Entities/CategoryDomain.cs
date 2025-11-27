using System.ComponentModel.DataAnnotations;

namespace TechStore.Domain.Entities
{
    public class CategoryDomain
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? CategoryName { get; set; }

        [Required]
        [MaxLength(200)]
        public string? CategoryDescription { get; set; }

        [ConcurrencyCheck]
        [Timestamp]
        public byte[] Version { get; set; }

        public ICollection<ProductDomain>? Products { get; set; }
    }
}
