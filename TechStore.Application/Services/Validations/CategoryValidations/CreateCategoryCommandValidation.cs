using FluentValidation;
using TechStore.Application.Features.Commands.Category;
using TechStore.Application.Interfaces;

namespace TechStore.Application.Services.Validations.CategoryValidations
{
    public class CreateCategoryCommandValidation : AbstractValidator<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _repo;

        public CreateCategoryCommandValidation(ICategoryRepository repo)
        {
            _repo = repo;

            RuleFor(c => c.CategoryName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);

            RuleFor(c => c.CategoryDescription)
                .NotEmpty()
                .NotNull()
                .MaximumLength(200);
                
        }
    }
}
