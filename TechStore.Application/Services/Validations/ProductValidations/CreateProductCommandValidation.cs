using FluentValidation;
using TechStore.Application.Features.Commands.Product;
using TechStore.Application.Interfaces;

namespace TechStore.Application.Services.Validations.ProductValidations
{
    public class CreateProductCommandValidation :AbstractValidator<CreateProductCommand>
    {
        private readonly IProductRepository _repo;

        public CreateProductCommandValidation(IProductRepository repo)
        {
            _repo = repo;

            RuleFor(p => p.ProductName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);

            RuleFor(p => p.ProductDescription)
                .NotEmpty()
                .NotNull()
                .MaximumLength(200);

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}
