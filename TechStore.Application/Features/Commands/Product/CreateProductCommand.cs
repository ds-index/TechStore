using MediatR;
using System.ComponentModel.DataAnnotations;

namespace TechStore.Application.Features.Commands.Product
{
    public class CreateProductCommand : IRequest<int>
    {
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

        [Required]
        public int CategoryId { get; set; }

        public override string ToString()
        {
            return $"{ProductName} | {ProductDescription} | {Price} | {Inventory}";
        }
    }
}
