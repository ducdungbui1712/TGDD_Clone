using AutoMapper;
using Products.API.Models;
using Products.API.Models.DTO;
namespace Products.API.Extension
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, Product>();
                config.CreateMap<Product, ProductDTO>();

                config.CreateMap<CategoryDTO, Category>();
                config.CreateMap<Category, CategoryDTO>();
            });
            return mappingConfig;
        }
    }
}
