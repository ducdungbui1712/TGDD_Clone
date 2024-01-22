using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Products.API.Data;
using Products.API.Models;
using Products.API.Models.DTO;
using Products.API.Services.IServices;

namespace Products.API.Services
{
    public class ProductService(
        DataContext dataContext,
        IMapper mapper
        )
        : IProductService
    {

        public async Task<ResponseDTO> GetProductsAsync()
        {
            try
            {
                IEnumerable<Product> products = await dataContext.Products.ToListAsync();
                return new ResponseDTO
                {
                    IsSuccess = true,
                    Result = mapper.Map<IEnumerable<ProductDTO>>(products)
                };
            }
            catch (Exception ex)
            {
                return new ResponseDTO
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDTO> GetProductByIdAsync(int id)
        {
            try
            {
                Product product = await dataContext.Products.FindAsync(id);
                if (product == null)
                {
                    return new ResponseDTO
                    {
                        IsSuccess = false,
                        Message = "Product not found."
                    };
                }

                return new ResponseDTO
                {
                    IsSuccess = true,
                    Result = mapper.Map<ProductDTO>(product)
                };
            }
            catch (Exception ex)
            {
                return new ResponseDTO
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDTO> GetCategoriesAsync()
        {
            try
            {
                IEnumerable<Category> categories = await dataContext.Categories.ToListAsync();
                return new ResponseDTO
                {
                    IsSuccess = true,
                    Result = mapper.Map<IEnumerable<CategoryDTO>>(categories)
                };
            }
            catch (Exception ex)
            {
                return new ResponseDTO
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDTO> GetCategoryByIdAsync(int categoryId)
        {
            try
            {
                Category category = await dataContext.Categories.FirstAsync(o => o.Id == categoryId);

                return new ResponseDTO
                {
                    IsSuccess = true,
                    Result = mapper.Map<CategoryDTO>(category)
                };
            }
            catch (Exception ex)
            {
                return new ResponseDTO
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDTO> GetProductsByCategoryAsync(int categoryId)
        {
            try
            {
                IEnumerable<Product> products = await dataContext.Products
                    .Where(p => p.CategoryId == categoryId)
                    .ToListAsync();

                return new ResponseDTO
                {
                    IsSuccess = true,
                    Result = mapper.Map<IEnumerable<ProductDTO>>(products)
                };
            }
            catch (Exception ex)
            {
                return new ResponseDTO
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDTO> SearchProductsAsync(string searchTerm)
        {
            try
            {
                IEnumerable<Product> products = await dataContext.Products
                    .Where(p => p.Model.Contains(searchTerm) || p.Description.Contains(searchTerm))
                    .ToListAsync();

                return new ResponseDTO
                {
                    IsSuccess = true,
                    Result = mapper.Map<IEnumerable<ProductDTO>>(products)
                };
            }
            catch (Exception ex)
            {
                return new ResponseDTO
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}

