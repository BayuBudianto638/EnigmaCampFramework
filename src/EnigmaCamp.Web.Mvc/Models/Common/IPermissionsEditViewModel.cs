using System.Collections.Generic;
using EnigmaCamp.Roles.Dto;

namespace EnigmaCamp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}