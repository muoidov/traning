using System.Collections.Generic;
using muoi.Roles.Dto;

namespace muoi.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
