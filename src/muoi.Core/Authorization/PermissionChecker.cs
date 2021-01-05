using Abp.Authorization;
using muoi.Authorization.Roles;
using muoi.Authorization.Users;

namespace muoi.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
