namespace Atlas.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserDto?> GetCurrentUserAsync();
    }
}
