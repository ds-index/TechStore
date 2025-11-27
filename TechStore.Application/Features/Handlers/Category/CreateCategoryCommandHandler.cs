using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using TechStore.Application.Features.Commands.Category;
using TechStore.Application.Interfaces;
using TechStore.Application.Services.Validations.CategoryValidations;
using TechStore.Domain.Entities;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
{
    private readonly ILogger<CreateCategoryCommandHandler> _logger;
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _repo;

    public CreateCategoryCommandHandler(ILogger<CreateCategoryCommandHandler> logger,
                                        IMapper mapper,
                                        ICategoryRepository repo)
    {
        _logger = logger;
        _mapper = mapper;
        _repo = repo;
    }

    public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        // 1️⃣ Validation
        var validator = new CreateCategoryCommandValidation(_repo);
        var validationResult = validator.Validate(request);
        if (!validationResult.IsValid)
        {
            throw new ArgumentException(string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage)));
        }

        // 2️⃣ Mapping
        var category = _mapper.Map<CategoryDomain>(request);

        // 3️⃣ Add to repository
        await _repo.Add(category);

        _logger.LogInformation("Category added successfully with Id {Id}", category.Id);

        return category.Id;
    }
}
