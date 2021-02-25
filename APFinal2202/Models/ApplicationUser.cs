using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;


namespace APFinal2202.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            return await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Role { get; set; }

        public string NationalIdentificationNumber { get; set; }

        public bool ReceiveNewsletter { get; set; }
    }
}