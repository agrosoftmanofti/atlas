using System.Threading.Tasks;
using Atlas.Core.Models;

namespace Atlas.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserDto?> GetCurrentUserAsync();
    }
}
