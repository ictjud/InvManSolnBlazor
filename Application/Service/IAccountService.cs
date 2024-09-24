using Application.DTO.Request.Identity;
using Application.DTO.Response.Identity;
using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public interface IAccountService
    {
        Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);

        Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model);

        Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUsersWithClaimsAsync();

        Task SetUpAsync();
        Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model);

        //Task SaveActivityAsync(ActivityTrackerRequestDTO model);
        //Task<IEnumerable<IGrouping<DateTime, ActivityTrackerResponseDTO>>> GroupActivities();
    }
}
