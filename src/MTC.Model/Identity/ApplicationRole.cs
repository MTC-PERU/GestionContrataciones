using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MTC.Model.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public List<ApplicationUserRole> UserRoles { get; set; }
    }
}
