using UserAuth.API.Services.IServices;
using UserAuth.API.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using UserAuth.API.Models;

namespace UserAuth.API.Apis
{
    public static class UserAuthApi
    {
        public static RouteGroupBuilder MapProductsApi(this RouteGroupBuilder app)
        {
            app.MapPost("/register", async ([FromServices] IAuthenticationService<ApplicationUser> _authenticationService, [FromBody] RegisterModelDTO registerModel) =>
            {
                return await _authenticationService.RegisterAsync(registerModel);
            });

            app.MapPost("/login", async ([FromServices] ILoginService<ApplicationUser> _loginService, [FromBody] LoginModel loginModel) =>
            {
                return await _loginService.LoginAccountAsync(loginModel);
            });
            return app;
        }
    }
}
