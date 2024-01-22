using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using UserAuth.API.Apis;
using UserAuth.API.Extension;



var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.AddApplicationExtensionServices();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Add authentication to Swagger UI
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

app.MapGroup("/api/auth")
   .WithTags("UserAuth API")
   .MapProductsApi()
   .WithOpenApi();

app.Run();
