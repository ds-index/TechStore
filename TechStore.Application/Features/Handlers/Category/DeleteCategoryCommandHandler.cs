using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using TechStore.Application.Exceptions;
using TechStore.Application.Features.Commands.Category;
using TechStore.Application.Interfaces;

namespace TechStore.Application.Features.Handlers.Category
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, bool>
    {

        private readonly ILogger<DeleteCategoryCommandHandler> _logger;
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _repo;

        public DeleteCategoryCommandHandler(ILogger<DeleteCategoryCommandHandler> logger, 
            IMapper mapper, 
            ICategoryRepository repo)
        {
            _logger = logger;
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var category = await _repo.GetByIdAsync(request.Id);

                if (category == null)
                {
                    throw new NotFoundException($"Not found:\n{request.ToString()}");
                }

                await _repo.Delete(category);
                _logger.LogInformation("Category updated successful!");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }
    }
}
