using AutoMapper;
using BabyCareMangoDbProject.DataAccess.Entities;
using BabyCareMangoDbProject.Dtos.ProductDtos;

namespace BabyCareMangoDbProject.Mappings
{
    public class ProductMapping:Profile

    {
        public ProductMapping() 
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
        }
    }
}
