using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Products.API.Data;
using Products.API.Services.IServices;
using Products.API.Services;

namespace Products.API.Extension
{
    public static class Extensions
    {
        public static void AddApplicationExtensionServices(this IHostApplicationBuilder builder)
        {
            var cs = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<DataContext>(options => {
                options.UseSqlServer(cs);
            });

            // Auto Mapper Register
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            builder.Services.AddSingleton(mapper);
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // ProductService
            builder.Services.AddScoped<IProductService, ProductService>();
        }
    }
}
