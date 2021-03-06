﻿using Microsoft.AspNetCore.Identity;

namespace MTC.Model.Identity
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public ApplicationUser User { get; set; }
        public ApplicationRole Role { get; set; }

    }
}
