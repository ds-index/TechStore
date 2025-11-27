using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using TechStore.Application.Exceptions;
using TechStore.Application.Features.Commands.Category;
using TechStore.Application.Interfaces;


namespace TechStore.Application.Features.Handlers.Category
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, bool>
    {
        private readonly ILogger<UpdateCategoryCommandHandler> _logger;
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _repo;

        public UpdateCategoryCommandHandler(ILogger<UpdateCategoryCommandHandler> logger, IMapper mapper, ICategoryRepository repo)
        {
            _logger = logger;
            _mapper = mapper;
            _repo = repo;
        }


        public async Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var category = await _repo.GetByIdAsync(request.Id);
                if (category == null)
                {
                    throw new NotFoundException($"Category with Id {request.Id} not found.");
                }

                _mapper.Map(request, category);

                await _repo.Update(category);

                _logger.LogInformation("Category updated successfully!");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating category");
                return false;
            }
        }

    }
}
