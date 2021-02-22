using APFinal2202.Contracts;
using APFinal2202.Models;
using APFinal2202.Services;
using APFinal2202.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace APFinal2202.Controllers
{
    [Authorize(Roles = "Administrator,SellerOrAgent")]
    public class AuctionController : Controller
    {
        public AuctionController()
        {
            context = new ApplicationDbContext();
            mapper = new Mapper();
        }

        public ActionResult StartAuction(string id)
        {
            var property = context.Properties.FirstOrDefault(it => it.Id == id);
            if (property == null)
            {
                return View("Error");
            }

            ViewBag.SubTitle = property.Title;
            TempData["propertyId"] = property.Id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> StartAuction(AuctionViewModel model)
        {
            var propertyId = (string)TempData["propertyId"];

            if (!ModelState.IsValid)
            {
                return View();
            }

            var auction = await context.Auctions.FirstOrDefaultAsync(it => it.PropertyId == propertyId);
            if (auction != null)
            {
                ViewBag.ErrorMessage = "There is already an auction created for this property. Please check the list of auctions.";
                return View("Error");
            }

            auction = mapper.Map(model, propertyId);
            context.Auctions.Add(auction);
            await context.SaveChangesAsync();

            return RedirectToAction("Properties4Seller", "Property");
        }

        //

        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
    }
}