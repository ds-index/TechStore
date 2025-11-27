using AutoMapper;
using TechStore.Application.DTOs;
using TechStore.Application.Features.Commands.Category;
using TechStore.Application.Features.Commands.Product;
using TechStore.Domain.Entities;

namespace TechStore.Application.Mappings
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<ProductDomain, ReqProductDTO>().ReverseMap();
            CreateMap<ProductDomain, ResProductDTO>().ReverseMap();

            CreateMap<CategoryDomain, ReqCategoryDTO>().ReverseMap();
            CreateMap<CategoryDomain, ResCategoryDTO>().ReverseMap();

            CreateMap<CategoryDomain, CreateCategoryCommand>().ReverseMap();
            CreateMap<ProductDomain, CreateProductCommand>().ReverseMap();

            CreateMap<CategoryDomain, UpdateCategoryCommand>().ReverseMap();
            CreateMap<ProductDomain, UpdateProductCommand>().ReverseMap();
        }
    }
}
