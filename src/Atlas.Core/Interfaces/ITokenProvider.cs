namespace Atlas.Core.Interfaces
{
    public interface ITokenProvider
    {
        Task<string?> GetAccessTokenAsync();
    }
}
