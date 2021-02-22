using APFinal2202.Contracts;
using APFinal2202.Helpers;
using APFinal2202.Models;
using APFinal2202.Services;
using APFinal2202.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace APFinal2202.Controllers
{
    [Authorize(Roles = "Administrator,Buyer")]
    public class BidController : Controller
    {
        public BidController()
        {
            context = new ApplicationDbContext();
            mapper = new Mapper();
        }
        public ActionResult PlaceBid(string id)
        {
            var property = context.Properties.FirstOrDefault(it => it.Id == id);
            if (property == null)
            {
                ViewBag.ErrorMessage = "The property selected is not found. Please check again the property you want to bid for.";
                return View("Error");
            }

            ViewBag.SubTitle = property.Title;
            TempData["propertyId"] = property.Id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> PlaceBid(BidViewModel model)
        {
            model.TimeOf = DateTime.Now.ToString("g");
            var buyer = GetBuyer();
            var propertyId = (string)TempData["propertyId"];

            var bids = await context.Bids.Where(it => it.PropertyId == propertyId).ToListAsync();

            if (bids.Any(dbBid => dbBid.Amount > model.Amount.GetDouble()))
            {
                ViewBag.ErrorMessage = "There bid is too low. Please try again.";
                return RedirectToAction("PlaceBid", new { id = propertyId });
            }

            ViewBag.ResultMessage = "Thank you for placing your bid.";
            var bid = mapper.Map(model, propertyId, buyer.Id);
            context.Bids.Add(bid);
            await context.SaveChangesAsync();
            return RedirectToAction("Properties4Buyer", "Property");
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