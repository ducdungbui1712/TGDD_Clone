using Microsoft.AspNetCore.Mvc;
using Products.API.Models.DTO;
using Products.API.Services;


namespace Products.API.Apis
{
    public static class ProductsApi
    {
        public static RouteGroupBuilder MapProductsApi(this RouteGroupBuilder app)
        {
            app.MapGet("/products", async Task<ResponseDTO> (ProductService productService) =>
            {
                return await productService.GetProductsAsync();
            });

            app.MapGet("/item/{id:int}", async Task<ResponseDTO> (ProductService productService, int id) =>
            {
                return await productService.GetProductByIdAsync(id);
            });

            app.MapGet("/category", async (ProductService productService) =>
            {
                return await productService.GetCategoriesAsync();
            });

            app.MapGet("/category/{id:int}", async Task<ResponseDTO> (ProductService productService, int id) =>
            {
                return await productService.GetCategoryByIdAsync(id);
            });

            app.MapGet("/products/{category}", async (ProductService productService, int category) =>
            {
                return await productService.GetProductsByCategoryAsync(category);
            });

            app.MapGet("/search", async (ProductService productService, [FromQuery] string searchTerm) =>
            {
                return await productService.SearchProductsAsync(searchTerm);
            });

            return app;
        }
    }
}
