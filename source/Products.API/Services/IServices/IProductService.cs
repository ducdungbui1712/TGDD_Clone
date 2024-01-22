using Products.API.Models.DTO;

namespace Products.API.Services.IServices
{
    public interface IProductService
    {
        Task<ResponseDTO> GetProductsAsync();
        Task<ResponseDTO> GetProductByIdAsync(int id);
        Task<ResponseDTO> GetCategoriesAsync();
        Task<ResponseDTO> GetCategoryByIdAsync(int categoryId);
        Task<ResponseDTO> GetProductsByCategoryAsync(int categoryId);
        Task<ResponseDTO> SearchProductsAsync(string searchTerm);
    }
}
