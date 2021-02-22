using APFinal2202.Models;
using APFinal2202.ViewModels.Account;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace APFinal2202.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class RolesController : Controller
    {
        public RolesController()
        {
            roleManager = new ApplicationRoleManager(new RoleStore<IdentityRole>(new ApplicationDbContext()));
            userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IdentityRole identityRole)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Create");
            }

            var result = await roleManager.CreateAsync(identityRole);
            return RedirectToAction(!result.Succeeded ? "Create" : "Index");
        }

        public ActionResult Index()
        {
            var roles = roleManager.Roles.ToList();
            var users = userManager.Users.ToList();

            var model = new UserRolesViewModel
            {
                Users = users,
                Roles = roles
            };
            return View(model);
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string role)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Delete");
            }

            var existingRoles = roleManager.Roles.ToList();
            var roleToDelete = existingRoles.FirstOrDefault(it => it.Name.Equals(role));

            var result = await roleManager.DeleteAsync(roleToDelete);
            return RedirectToAction(!result.Succeeded ? "Delete" : "Index");
        }

        //

        private readonly ApplicationRoleManager roleManager;
        private readonly ApplicationUserManager userManager;
    }
}