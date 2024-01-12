using AutoMapper;
using Azure;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Products.API.Data;
using Products.API.Models;
using Products.API.Models.DTO;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace Products.API.Apis
{
    public static class ProductsApi
    {
        public static RouteGroupBuilder MapProductsApi(this RouteGroupBuilder app)
        {
            //GetProductsDTO
            app.MapGet("/products", async Task<ResponseDTO> (DataContext dataConText, IMapper mapper) =>
            {
                ResponseDTO _response = new ResponseDTO();
                try
                {
                    IEnumerable<Product> objList = await dataConText.Products.ToListAsync();
                    _response.Result = mapper.Map<IEnumerable<ProductDTO>>(objList);
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.Message = ex.Message;
                }
                return _response;
            });

            //GetProductsDTOById
            app.MapGet("/items/{id:int}", async Task<ResponseDTO> (DataContext dataConText, IMapper mapper, int id) =>
            {
                ResponseDTO _response = new ResponseDTO();
                try
                {
                    Product obj = await dataConText.Products.FirstAsync(o => o.Id == id);
                    _response.Result = mapper.Map<ProductDTO>(obj);
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.Message = ex.Message;
                }
                return _response;
            });

            //GetCategoryDTO
            app.MapGet("/category", async Task<ResponseDTO> (DataContext dataConText, IMapper mapper) =>
            {
                ResponseDTO _response = new ResponseDTO();
                try
                {
                    IEnumerable<Category> objList = await dataConText.Categories.ToListAsync();
                    _response.Result = mapper.Map<IEnumerable<CategoryDTO>>(objList);
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.Message = ex.Message;
                }
                return _response;
            });

            //GetCategoryDTOById
            app.MapGet("/category/{id:int}", async Task<ResponseDTO> (DataContext dataConText, IMapper mapper, int id) =>
            {
                ResponseDTO _response = new ResponseDTO();
                try
                {
                    Category obj = await dataConText.Categories.FirstAsync(o => o.Id == id);
                    _response.Result = mapper.Map<CategoryDTO>(obj);
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.Message = ex.Message;
                }
                return _response;
            });

            //GetProductsByCategory
            app.MapGet("/products/{category}", async Task<ResponseDTO> (DataContext dataConText, IMapper mapper, int category) =>
            {
                ResponseDTO _response = new ResponseDTO();
                try
                {
                    IEnumerable<Product> objList = await dataConText.Products.Where(o => o.CategoryId == category).ToListAsync();

                    _response.Result = mapper.Map<IEnumerable<ProductDTO>>(objList);
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.Message = ex.Message;
                }
                return _response;
            });

            //GetCategory

            //SearchProduct
            app.MapGet("/search", async Task<ResponseDTO> (DataContext dataConText, IMapper mapper, [FromQuery] string searchTerm) =>
            {
                ResponseDTO _response = new ResponseDTO();
                try
                {
                    var tempKeyword = searchTerm;
                    IEnumerable<Product> objList = await dataConText.Products.Where(o => o.Model.Contains(tempKeyword)).ToListAsync();

                    _response.Result = mapper.Map<IEnumerable<ProductDTO>>(objList);
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.Message = ex.Message;
                }
                return _response;
            });

            return app;
        }
    }
}
