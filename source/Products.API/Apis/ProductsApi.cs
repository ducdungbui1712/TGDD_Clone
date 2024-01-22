using Microsoft.AspNetCore.Mvc;
using Products.API.Models.DTO;
using Products.API.Services.IServices;


namespace Products.API.Apis
{
    public static class ProductsApi
    {
        public static RouteGroupBuilder MapProductsApi(this RouteGroupBuilder app)
        {
            app.MapGet("/products", async (IProductService _productService) =>
            {
                return await _productService.GetProductsAsync();
            });

            app.MapGet("/item/{id:int}", async (IProductService _productService, int id) =>
            {
                return await _productService.GetProductByIdAsync(id);
            });

            app.MapGet("/category", async (IProductService _productService) =>
            {
                return await _productService.GetCategoriesAsync();
            });

            app.MapGet("/category/{id:int}", async (IProductService _productService, int id) =>
            {
                return await _productService.GetCategoryByIdAsync(id);
            });

            app.MapGet("/products/{category}", async (IProductService _productService, int category) =>
            {
                return await _productService.GetProductsByCategoryAsync(category);
            });

            app.MapGet("/search", async (IProductService _productService, [FromQuery] string searchTerm) =>
            {
                return await _productService.SearchProductsAsync(searchTerm);
            });

            return app;
        }
    }
}
