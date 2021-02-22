using System.Web.Mvc;

namespace APFinal2202.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}