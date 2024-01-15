using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Products.API.Data;
using Products.API.Models;
using Products.API.Models.DTO;

namespace Products.API.Services
{
    public class ProductService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public ProductService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<ResponseDTO> GetProductsAsync()
        {
            try
            {
                IEnumerable<Product> products = await _dataContext.Products.ToListAsync();
                return new ResponseDTO
                {
                    IsSuccess = true,
                    Result = _mapper.Map<IEnumerable<ProductDTO>>(products)
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
                Product product = await _dataContext.Products.FindAsync(id);
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
                    Result = _mapper.Map<ProductDTO>(product)
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
                IEnumerable<Category> categories = await _dataContext.Categories.ToListAsync();
                return new ResponseDTO
                {
                    IsSuccess = true,
                    Result = _mapper.Map<IEnumerable<CategoryDTO>>(categories)
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
                Category category = await _dataContext.Categories.FirstAsync(o => o.Id == categoryId);

                return new ResponseDTO
                {
                    IsSuccess = true,
                    Result = _mapper.Map<CategoryDTO>(category)
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
                IEnumerable<Product> products = await _dataContext.Products
                    .Where(p => p.CategoryId == categoryId)
                    .ToListAsync();

                return new ResponseDTO
                {
                    IsSuccess = true,
                    Result = _mapper.Map<IEnumerable<ProductDTO>>(products)
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
                IEnumerable<Product> products = await _dataContext.Products
                    .Where(p => p.Model.Contains(searchTerm) || p.Description.Contains(searchTerm))
                    .ToListAsync();

                return new ResponseDTO
                {
                    IsSuccess = true,
                    Result = _mapper.Map<IEnumerable<ProductDTO>>(products)
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

