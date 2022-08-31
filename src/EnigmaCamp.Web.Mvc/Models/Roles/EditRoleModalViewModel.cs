using Abp.AutoMapper;
using EnigmaCamp.Roles.Dto;
using EnigmaCamp.Web.Models.Common;

namespace EnigmaCamp.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
