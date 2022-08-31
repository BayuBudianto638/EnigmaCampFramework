using Abp.Authorization;
using EnigmaCamp.Authorization.Roles;
using EnigmaCamp.Authorization.Users;

namespace EnigmaCamp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
