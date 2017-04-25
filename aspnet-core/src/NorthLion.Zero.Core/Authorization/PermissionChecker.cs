using Abp.Authorization;
using NorthLion.Zero.Authorization.Roles;
using NorthLion.Zero.Authorization.Users;
using NorthLion.Zero.MultiTenancy;

namespace NorthLion.Zero.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
