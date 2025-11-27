using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using TechStore.Application.Exceptions;
using TechStore.Application.Features.Commands.Product;
using TechStore.Application.Interfaces;
using TechStore.Domain.Entities;

namespace TechStore.Application.Features.Handlers.Product
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly ILogger<UpdateProductCommandHandler> _logger;
        private readonly IMapper _mapper;
        private readonly IProductRepository _repo;

        public UpdateProductCommandHandler(ILogger<UpdateProductCommandHandler> logger, 
            IMapper mapper, 
            IProductRepository repo)
        {
            _logger = logger;
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
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
