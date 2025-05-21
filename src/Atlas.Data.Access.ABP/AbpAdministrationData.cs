using Atlas.Core.Models;
using Atlas.Data.Access.Interfaces;

namespace Atlas.Data.Access.ABP;

// Placeholder implementation that would interact with ABP Identity modules.
public class AbpAdministrationData : IAdministrationData
{
    public Authorisation? Authorisation { get; private set; }

    public Task<Authorisation?> GetAuthorisationAsync(string? user, CancellationToken cancellationToken)
    {
        // TODO: call ABP identity to get user permissions
        return Task.FromResult<Authorisation?>(null);
    }

    public Task<IEnumerable<User>> GetUsersAsync(CancellationToken cancellationToken) => Task.FromResult<IEnumerable<User>>(Array.Empty<User>());
    public Task<User> GetUserAsync(int userId, CancellationToken cancellationToken) => Task.FromResult(new User());
    public Task<User> CreateUserAsync(User user, CancellationToken cancellationToken) => Task.FromResult(user);
    public Task<User> UpdateUserAsync(User user, CancellationToken cancellationToken) => Task.FromResult(user);
    public Task<int> DeleteUserAsync(int userId, CancellationToken cancellationToken) => Task.FromResult(0);
    public Task<IEnumerable<Role>> GetRolesAsync(CancellationToken cancellationToken) => Task.FromResult<IEnumerable<Role>>(Array.Empty<Role>());
    public Task<Role> GetRoleAsync(int roleId, CancellationToken cancellationToken) => Task.FromResult(new Role());
    public Task<Role> CreateRoleAsync(Role role, CancellationToken cancellationToken) => Task.FromResult(role);
    public Task<Role> UpdateRoleAsync(Role role, CancellationToken cancellationToken) => Task.FromResult(role);
    public Task<int> DeleteRoleAsync(int roleId, CancellationToken cancellationToken) => Task.FromResult(0);
    public Task<IEnumerable<Permission>> GetPermissionsAsync(CancellationToken cancellationToken) => Task.FromResult<IEnumerable<Permission>>(Array.Empty<Permission>());
    public Task<Permission> GetPermissionAsync(int permissionId, CancellationToken cancellationToken) => Task.FromResult(new Permission());
    public Task<Permission> CreatePermissionAsync(Permission permission, CancellationToken cancellationToken) => Task.FromResult(permission);
    public Task<Permission> UpdatePermissionAsync(Permission permission, CancellationToken cancellationToken) => Task.FromResult(permission);
    public Task<int> DeletePermissionAsync(int permissionId, CancellationToken cancellationToken) => Task.FromResult(0);
    public Task<List<ChecklistItem>> GetPermissionChecklistAsync(List<Permission> modelPermissions, CancellationToken cancellationToken) => Task.FromResult(new List<ChecklistItem>());
    public Task<List<ChecklistItem>> GetRoleChecklistAsync(List<Role> modelRoles, CancellationToken cancellationToken) => Task.FromResult(new List<ChecklistItem>());
}
