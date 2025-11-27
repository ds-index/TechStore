using MediatR;
using System.ComponentModel.DataAnnotations;

namespace TechStore.Application.Features.Commands.Category
{
    public class CreateCategoryCommand : IRequest<int>
    {
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
