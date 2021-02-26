using APFinal2202.Contracts;
using APFinal2202.Models;
using APFinal2202.Services;
using APFinal2202.ViewModels.Buyer;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace APFinal2202.Controllers
{
    [Authorize(Roles = "Administrator,Buyer")]
    public class BuyerController : Controller
    {
        public BuyerController()
        {
            context = new ApplicationDbContext();
            mapper = new Mapper();
        }

        public ActionResult Details()
        {
            var buyer = GetBuyer();

            return buyer == null
                ? RedirectToAction("SetDetails")
                : RedirectToAction("GetDetails");

        }

        public ActionResult BuyersGuide()
        {
            return View();
        }

        public ActionResult SetDetails()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SetDetails(SetDetailsBuyerViewModel model)
        {
            var (multimedia, address, buyer) = mapper.Map(model, User.Identity.GetUserId());

            context.MultiMedias.Add(multimedia);
            context.Addresses.Add(address);
            context.Buyers.Add(buyer);

            await context.SaveChangesAsync();
            return RedirectToAction("Properties4Buyer", "Property");
        }

        public ActionResult GetDetails()
        {
            var userId = User.Identity.GetUserId();
            var user = context.Users.FirstOrDefault(it => it.Id == userId);
            var buyer = context.Buyers.FirstOrDefault(it => it.UserId == user.Id);
            var address = context.Addresses.FirstOrDefault(it => it.Id == buyer.AddressId);
            var multimedia = context.MultiMedias.FirstOrDefault(it => it.Id == buyer.MultimediaId);
            var model = mapper.Map(buyer, user, address, multimedia);
            return View(model);
        }

        public ActionResult EditDetails()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditDetails(SetDetailsBuyerViewModel model)
        {
            var userId = User.Identity.GetUserId();
            var existingBuyer = await context.Buyers.FirstOrDefaultAsync(it => it.UserId == userId);
            if (existingBuyer == null)
            {
                ViewBag.ErrorMessage = "This buyer does not exists in our database.";
                return View("Error");
            }

            var address = await context.Addresses.FirstOrDefaultAsync(it => it.Id == existingBuyer.AddressId);
            var multimedia = await context.MultiMedias.FirstOrDefaultAsync(it => it.Id == existingBuyer.MultimediaId);

            (multimedia, address, existingBuyer) = mapper.Map(model, userId);
            return RedirectToAction("GetDetails", "Seller");
        }

        //

        private readonly ApplicationDbContext context;

        private readonly IMapper mapper;

        private Buyer GetBuyer()
        {
            var userId = User.Identity.GetUserId();
            var user = context.Users.FirstOrDefault(it => it.Id == userId);
            var buyer = context.Buyers.FirstOrDefault(it => it.UserId == user.Id);
            return buyer;
        }
    }
}