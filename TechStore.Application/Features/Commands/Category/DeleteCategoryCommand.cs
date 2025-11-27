using MediatR;
using System.ComponentModel.DataAnnotations;

namespace TechStore.Application.Features.Commands.Category
{
    public class DeleteCategoryCommand : IRequest<bool>
    {
        [Key]
        public int Id { get; set; }
    }
}
