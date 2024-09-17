using Application.DTO.Response;
using Application.DTO.Response.ActivityTracker;
using Application.DTO.Response.Identity;
using Application.DTO.Resquest.ActivityTracker;
using Application.DTO.Resquest.Identity;

namespace Application.Interface.Identity
{
    public interface IAccount
    {
        Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);

        Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model);

        Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUsersWithClaimsAsync();

        Task SetUpAsync();

        Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model);
        Task SaveActivityAsync(ActivityTrackerRequestDTO model);

        Task<IEnumerable<ActivityTrackerResponseDTO>> GetActivitiesAsync();
    }

}

