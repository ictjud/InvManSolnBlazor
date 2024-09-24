using Application.DTO.Request.Identity;
using Application.DTO.Response;
using Application.DTO.Response.Identity;
using Application.Interface.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class AccountService(IAccount account) : IAccountService
    {
        public async Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model)
            => await account.CreateUserAsync(model);

        public async Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUsersWithClaimsAsync()
            => await account.GetUsersWithClaimsAsync();

        public async Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model)
            => await account.LoginAsync(model);

        public async Task SetUpAsync()
            => await account?.SetUpAsync();

        public Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model)
            => account.UpdateUserAsync(model);
        /*
         private async Task<IEnumerable<ActivityTrackerResponseDTO>> GetActivities()
            => await account.GetActivitiesAsync();
         public  Task SaveActivityAsync(ActivityTrackerDTO model)
            => account.SaveActivity(model);

        public async Task<IEnumerable<IGrouping<DateTime, ActivityTrackerResponseDTO>>> Activities()
        {
            var data = (await GetActiviesAsync()).GroupBy(e => e.Data).AsEnumerable();
            return data;
        }
         */
    }
}
