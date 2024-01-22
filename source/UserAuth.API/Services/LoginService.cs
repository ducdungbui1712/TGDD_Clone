using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserAuth.API.Models;
using UserAuth.API.Models.DTO;
using UserAuth.API.Services.IServices;

namespace UserAuth.API.Services
{
    public class LoginService(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        IConfiguration configuration
        )
        : ILoginService<ApplicationUser>
    {

        public Task SignIn(ApplicationUser user)
        {
            return signInManager.SignInAsync(user, true);
        }

        public Task SignInAsync(ApplicationUser user, AuthenticationProperties properties, string authenticationMethod = null)
        {
            return signInManager.SignInAsync(user, properties, authenticationMethod);
        }

        public async Task<ResponseDTO> LoginAccountAsync(LoginModel login)
        {
            var getUser = await userManager.FindByEmailAsync(login.Email);
            if (getUser is null)
                return new ResponseDTO {IsSuccess = false, Message = "User not found" };

            bool checkUserPasswords = await userManager.CheckPasswordAsync(getUser, login.Password);
            if (!checkUserPasswords)
                return new ResponseDTO { IsSuccess = false, Message = "Invalid email/password" };

            var getUserRole = await userManager.GetRolesAsync(getUser);
            string token = GenerateJwtToken(getUser.Id, getUser.Name, getUser.Email, getUserRole.First());

            await SignIn(getUser);

            return new ResponseDTO {Result = token!, IsSuccess = true, Message = "Login completed" };
        }

        public string GenerateJwtToken(string id, string name, string? email, string role)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var userClaims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, id),
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, role)
            };

            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                claims: userClaims,
                expires: DateTime.Now.AddDays(Convert.ToDouble(configuration["Jwt:ExpiryInDays"])),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
