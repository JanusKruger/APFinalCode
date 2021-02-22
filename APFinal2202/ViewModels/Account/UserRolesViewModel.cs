using APFinal2202.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace APFinal2202.ViewModels.Account
{
    public class UserRolesViewModel
    {
        public List<ApplicationUser> Users { get; set; }

        public List<IdentityRole> Roles { get; set; }
    }
}