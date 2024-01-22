using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using UserAuth.API.Models;
using UserAuth.API.Models.DTO;
using UserAuth.API.Services.IServices;

namespace UserAuth.API.Services
{
    public class AuthenticationService(
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IMapper mapper,
        IConfiguration config) 
        : IAuthenticationService<ApplicationUser>
    {

        public async Task<ResponseDTO> RegisterAsync(RegisterModelDTO registerDTO)
        {
            // Validate the model
            var validationResponse = ValidateModel(registerDTO);
            if (!validationResponse.IsSuccess)
            {
                return validationResponse;
            }

            try
            {
                var newUser = mapper.Map<ApplicationUser>(registerDTO);

                var user = await userManager.FindByEmailAsync(newUser.Email);
                if (user is not null) return new ResponseDTO { IsSuccess = false, Message = "User registered already" };

                var createUser = await userManager.CreateAsync(newUser, registerDTO.Password);
                if (!createUser.Succeeded) new ResponseDTO { IsSuccess = false, Message = string.Join(", ", createUser.Errors.Select(e => e.Description)) };

                // Assign default role: Admin to first register, rest is User
                var checkAdmin = await roleManager.FindByNameAsync("Admin");
                if (checkAdmin is null)
                {
                    await roleManager.CreateAsync(new IdentityRole() { Name = "Admin" });
                    await userManager.AddToRoleAsync(newUser, "Admin");
                    return new ResponseDTO { IsSuccess = true, Result = "User registered successfully!" };
                }
                else
                {
                    var checkUser = await roleManager.FindByNameAsync("User");
                    if (checkUser is null)
                        await roleManager.CreateAsync(new IdentityRole() { Name = "User" });

                    await userManager.AddToRoleAsync(newUser, "User");
                    return new ResponseDTO { IsSuccess = true, Result = "User registered successfully!" };
                }

            }
            catch (Exception ex)
            {
                return new ResponseDTO { IsSuccess = false, Message = ex.Message };
            }
        }

        private ResponseDTO ValidateModel(RegisterModelDTO model)
        {
            var validationContext = new ValidationContext(model);
            var validationResults = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);

            return isValid
                ? new ResponseDTO { IsSuccess = true }
                : new ResponseDTO { IsSuccess = false, Message = string.Join(", ", validationResults.Select(e => e.ErrorMessage)) };
        }
    }
}
