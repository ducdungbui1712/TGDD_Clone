using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Products.API.Apis;
using Products.API.Data;
using Products.API.Extension;
using Products.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var cs = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(options => {
    options.UseSqlServer(cs);
});

// Auto Mapper Register
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Services
builder.Services.AddScoped<ProductService>();


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGroup("/api")
   .WithTags("Products API")
   .MapProductsApi();

app.Run();

