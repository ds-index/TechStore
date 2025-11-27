using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using TechStore.Application.Exceptions;
using TechStore.Application.Features.Commands.Product;
using TechStore.Application.Interfaces;

namespace TechStore.Application.Features.Handlers.Product
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly ILogger<DeleteProductCommandHandler> _logger;
        private readonly IMapper _mapper;
        private readonly IProductRepository _repo;

        public DeleteProductCommandHandler(ILogger<DeleteProductCommandHandler> logger, IMapper mapper, IProductRepository repo)
        {
            _logger = logger;
            _mapper = mapper;
            _repo = repo;
        }


        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var product = await _repo.GetByIdAsync(request.Id);

                if(product is null)
                {
                    throw new NotFoundException($"Not Found product with id: {request.Id}!");
                }

                await _repo.Delete(product);
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
