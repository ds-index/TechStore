using MediatR;
using System.ComponentModel.DataAnnotations;

namespace TechStore.Application.Features.Commands.Category
{
    public class UpdateCategoryCommand : IRequest<bool>
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? CategoryName { get; set; }

        [Required]
        [MaxLength(200)]
        public string? CategoryDescription { get; set; }

        public override string ToString()
        {
            return $"{CategoryName} | {CategoryDescription}";
        }
    }
}
