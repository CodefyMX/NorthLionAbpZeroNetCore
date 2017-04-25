using System.Collections.Generic;
using Abp.Application.Services;
using NorthLion.Zero.PaginatedModel;
using NorthLion.Zero.Users.Dto;
using System.Threading.Tasks;

namespace NorthLion.Zero.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task CreateUser(CreateUserInput input);
        Task<UsersOutput> GetUsers(PaginatedInputDto input);
        Task<EditProfileInput> GetUserProfile(int id);
        Task<CurrentUserPermissionsOutput> GetUserPermissions(long userId);
        Task<EditProfileInput> GetUserProfileForEdit();
        Task<UpdateUserInput> GetUserForEdit(long? userId);
        Task<UserRoleSelectorOutput> GetRolesForUser(long userId);
        Task SetUserRoles(SetUserRolesInput input);
        Task UpdateUserProfilePicture(long userId, string profilePicture);
        Task ChangeUserPassword(ChangePasswordInput input);
        Task UpdateUserProfile(EditProfileInput input);
        Task EditUser(UpdateUserInput input);
        Task ChangePasswordFromAdmin(ChangePasswordInput input);
        Task ProhibitPermission(ProhibitPermissionInput input);
        Task SetUserSpecialPermissions(SetUserSpecialPermissionsInput input);
        Task RemoveUserFromRole(long userId, string roleName);
        Task ResetPermissions(long userId);
        Task UnlockUser(long userId);
        Task LockUser(long userId);
        Task DeleteUser(long userId);
        Task<List<string>> GetPermissions();
        Task<List<string>> GetRoles();
        Task<UsersOutput> GetUsersInRole(string roleName);
    }
}