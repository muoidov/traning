using System.Collections.Generic;
using muoi.Roles.Dto;

namespace muoi.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
