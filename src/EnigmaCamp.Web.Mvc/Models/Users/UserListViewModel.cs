using System.Collections.Generic;
using EnigmaCamp.Roles.Dto;

namespace EnigmaCamp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
