using System.Threading.Tasks;
using Atlas.Core.Interfaces;
using Atlas.Core.Models;
using Volo.Abp.Identity;

namespace Atlas.Integration.ABP
{
    public class AbpUserService : IUserService
    {
        private readonly IUserAppService _userAppService;

        public AbpUserService(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<UserDto?> GetCurrentUserAsync()
        {
            return await _userAppService.GetCurrentAsync();
        }
    }
}
