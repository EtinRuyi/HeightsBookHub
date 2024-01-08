using HeightsBookHub.Domain.DTOs;
using HeightsBookHub.Domain.Entities.SharedEntities;

namespace HeightsBookHub.Application.Service.Interface
{
    public interface IAuthenticationService
    {
        Task<BaseResponse<UserReturnDto>> RegisterAsync(UserRegDTO userReg);
    }
}
