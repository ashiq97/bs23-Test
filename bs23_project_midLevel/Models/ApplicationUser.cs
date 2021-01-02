using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bs23_project_midLevel.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserFullName { get; set; }
    }
}
