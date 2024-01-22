using CloneTGDD.Web.Models.DTO;

namespace CloneTGDD.Web.Services
{
    public class UserAuthApiClient(HttpClient client)
    {
        private readonly string remoteServiceBaseUrl = "/api/auth";

        public async Task<ResponseDTO> RegisterUser(RegisterDTO registerModel)
        {
            var uri = $"{remoteServiceBaseUrl}/register";
            var response = await client.PostAsJsonAsync(uri, registerModel);

            return (response.IsSuccessStatusCode)
                ? new ResponseDTO { IsSuccess = true, Message = null }
                : new ResponseDTO { IsSuccess = false, Message = "Registration failed." };
        }
    }
}
