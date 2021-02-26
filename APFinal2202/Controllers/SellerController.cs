using APFinal2202.Contracts;
using APFinal2202.Models;
using APFinal2202.Services;
using APFinal2202.ViewModels.SellerOrAgent;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace APFinal2202.Controllers
{
    [Authorize(Roles = "Administrator,SellerOrAgent")]
    public class SellerController : Controller
    {
        public SellerController()
        {
            context = new ApplicationDbContext();
            mapper = new Mapper();
        }

        public ActionResult Details()
        {
            var seller = GetSeller();

            return seller == null
                ? RedirectToAction("SetDetails")
                : RedirectToAction("GetDetails");
        }

        public ActionResult GetDetails()
        {
            var userId = User.Identity.GetUserId();
            var user = context.Users.FirstOrDefault(it => it.Id == userId);
            var seller = context.Sellers.FirstOrDefault(it => it.UserId == user.Id);
            var address = context.Addresses.FirstOrDefault(it => it.Id == seller.AddressId);
            var multimedia = context.MultiMedias.FirstOrDefault(it => it.Id == seller.MultimediaId);
            var model = mapper.Map(seller, user, address, multimedia);
            return View(model);
        }

        public ActionResult SetDetails()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SetDetails(SetSellerDetailsViewModel model)
        {
            var (multimedia, address, seller) = mapper.Map(model, User.Identity.GetUserId());

            context.MultiMedias.Add(multimedia);
            context.Addresses.Add(address);
            context.Sellers.Add(seller);

            await context.SaveChangesAsync();
            return RedirectToAction("SubmitProperty", "Property");
        }

        public ActionResult EditDetails()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditDetails(SetSellerDetailsViewModel model)
        {
            var userId = User.Identity.GetUserId();

            var existingSeller = await context.Sellers.FirstOrDefaultAsync(it => it.UserId == userId);
            if (existingSeller == null)
            {
                ViewBag.ErrorMessage = "This seller does not exists in our database.";
                return View("Error");
            }

            var address = await context.Addresses.FirstOrDefaultAsync(it => it.Id == existingSeller.AddressId);
            var multimedia = await context.MultiMedias.FirstOrDefaultAsync(it => it.Id == existingSeller.MultimediaId);

            (multimedia, address, existingSeller) = mapper.Map(model, userId);
            return RedirectToAction("GetDetails", "Seller");
        }

        //

        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        private Seller GetSeller()
        {
            var userId = User.Identity.GetUserId();
            var user = context.Users.FirstOrDefault(it => it.Id == userId);
            var seller = context.Sellers.FirstOrDefault(it => it.UserId == user.Id);
            return seller;
        }

        public ActionResult SellersGuide()
        {
            return View();
        }
    }
}