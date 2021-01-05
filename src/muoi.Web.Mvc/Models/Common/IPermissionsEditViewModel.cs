using System.Collections.Generic;
using muoi.Roles.Dto;

namespace muoi.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}