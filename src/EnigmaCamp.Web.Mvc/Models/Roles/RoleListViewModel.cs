using System.Collections.Generic;
using EnigmaCamp.Roles.Dto;

namespace EnigmaCamp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
