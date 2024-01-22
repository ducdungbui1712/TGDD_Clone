using Microsoft.AspNetCore.Authentication;
using UserAuth.API.Models;
using UserAuth.API.Models.DTO;

namespace UserAuth.API.Services.IServices
{
    public interface ILoginService<T>
    {
        Task SignIn(T user);

        Task SignInAsync(T user, AuthenticationProperties properties, string authenticationMethod = null);

        Task<ResponseDTO> LoginAccountAsync(LoginModel login);
    }
}
