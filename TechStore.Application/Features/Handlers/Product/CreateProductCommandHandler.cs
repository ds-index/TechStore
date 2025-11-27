using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using TechStore.Application.Exceptions;
using TechStore.Application.Features.Commands.Product;
using TechStore.Application.Interfaces;
using TechStore.Application.Services.Validations.ProductValidations;
using TechStore.Domain.Entities;

namespace TechStore.Application.Features.Handlers.Product
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly ILogger<CreateProductCommandHandler> _logger;
        private readonly IMapper _mapper;
        private readonly IProductRepository _repo;

        public CreateProductCommandHandler(ILogger<CreateProductCommandHandler> logger, IMapper mapper, IProductRepository repo)
        {
            _logger = logger;
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new CreateProductCommandValidation(_repo);
                var validationRequest = validator.Validate(request);


                var product = _mapper.Map<ProductDomain>(request);

                if(product is null)
                {
                    throw new NotFoundException($"Not Found:\n{request.ToString()}");
                }
                if(!validationRequest.IsValid)
                {
                    throw new ArgumentException("Not valid for add product to db!");
                }

                _logger.LogInformation("Product add to db successful!");

                await _repo.Add(product);

                return product.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return 0;
            }
        }
    }
}
