using UserAuth.API.Models;
using UserAuth.API.Models.DTO;

namespace UserAuth.API.Services.IServices
{
    public interface IAuthenticationService<T>
    {
        Task<ResponseDTO> RegisterAsync(RegisterModelDTO registerDTO);
    }
}
