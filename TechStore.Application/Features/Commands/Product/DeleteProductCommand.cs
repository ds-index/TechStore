using MediatR;
using System.ComponentModel.DataAnnotations;

namespace TechStore.Application.Features.Commands.Product
{
    public class DeleteProductCommand : IRequest<bool>
    {
        [Key]
        public int Id { get; set; }
    }
}
