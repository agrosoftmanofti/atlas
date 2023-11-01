﻿using Atlas.Core.Models;

namespace Atlas.Data.Access.Interfaces
{
    public interface IAdministrationData : IAuthorisationData
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserAsync(int userId);
        Task<User> AddUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<int> DeleteUserAsync(int userId);
        Task<IEnumerable<Permission>> GetPermissionsAsync();
        Task<Permission> GetPermissionAsync(int permissionId);
        Task<Permission> AddPermissionAsync(Permission permission);
        Task<Permission> UpdatePermissionAsync(Permission permission);
        Task<int> DeletePermissionAsync(int permissionId);
        Task<IEnumerable<Role>> GetRolesAsync();
        Task<Role> GetRoleAsync(int roleId);
        Task<Role> AddRoleAsync(Role role);
        Task<Role> UpdateRoleAsync(Role role);
        Task<int> DeleteRoleAsync(int roleId);
    }
}
