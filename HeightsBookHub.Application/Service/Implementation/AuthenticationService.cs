using HeightsBookHub.Application.Service.Interface;
using HeightsBookHub.Domain.DTOs;
using HeightsBookHub.Domain.Entities;
using HeightsBookHub.Domain.Entities.SharedEntities;
using HeightsBookHub.Persistence.Repository.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace HeightsBookHub.Application.Service.Implementation
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository _authenticationRepo;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        IConfiguration _config;

        public AuthenticationService(IConfiguration config, UserManager<User> userManager, IAuthenticationRepository authenticationRepo, SignInManager<User> signInManager)
        {
            _authenticationRepo = authenticationRepo;
            _signInManager = signInManager;
            _userManager = userManager;
            _config = config;
        }

        public async Task<BaseResponse<UserReturnDto>> RegisterAsync(UserRegDTO userReg)
        {
            var response = new BaseResponse<UserReturnDto>();
            try
            {
                var userfound = await _authenticationRepo.GetUserByEmail(userReg.Email);
                if (userfound != null)
                {
                    response.Message = "User email already exists";
                    response.Succeeded = false;
                    response.StatusCode = 400;
                }
                else
                {
                    var user = new User
                    {
                        FirstName = userReg.FirstName,
                        LastName = userReg.LastName,
                        Email = userReg.Email,
                        Gender = userReg.Gender,
                        PhoneNumber = userReg.PhoneNumber,
                        UserName = userReg.UserName
                    };

                    if (await _authenticationRepo.AddUser(user, userReg.Password))
                    {
                        var userReturnDto = new UserReturnDto
                        {
                            Id = user.Id,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Email = user.Email,
                            PhoneNumber = user.PhoneNumber,
                            UserName = user.UserName,
                            Gender = user.Gender
                        };
                        response = BaseResponse<UserReturnDto>.Success(userReturnDto, "User registered successfully", 200);
                    }
                }
                return response;
            }
            catch (Exception e)
            {
                response.Message = "Error: " + e;
                response.Succeeded = false;
                response.StatusCode = 500;
                return response;
            }
        }
    }
}
