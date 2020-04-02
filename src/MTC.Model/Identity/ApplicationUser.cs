using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MTC.Model.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime? Birthday { get; set; }
        public List<ApplicationUserRole> UserRoles { get; set; }

    }
}
