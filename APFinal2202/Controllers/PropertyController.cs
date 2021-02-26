using APFinal2202.Contracts;
using APFinal2202.Enums;
using APFinal2202.Helpers;
using APFinal2202.Models;
using APFinal2202.Services;
using APFinal2202.ViewModels.Property;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace APFinal2202.Controllers
{
    public class PropertyController : Controller
    {
        public PropertyController()
        {
            context = new ApplicationDbContext();
            mapper = new Mapper();
        }

        [Authorize(Roles = "Administrator,Buyer")]
        public ActionResult Properties4Buyer()
        {
            var properties = context.Properties.ToList();
            var details = context.PropertyDetails.ToList();
            var features = context.PropertyFeatures.ToList();
            var addresses = context.Addresses.ToList();
            var multiMedias = context.MultiMedias.ToList();
            var auctions = context.Auctions.ToList();

            var tuple = new Tuple<List<Property>, List<PropertyDetail>, List<PropertyFeature>, List<Address>, List<Multimedia>, List<Auction>>(properties, details, features, addresses, multiMedias, auctions);
            var model = mapper.Map(tuple);
            return View(model);
        }

        [Authorize(Roles = "Administrator,SellerOrAgent")]
        public ActionResult Properties4Seller()
        {
            var seller = GetSeller();
            var properties = context.Properties.Where(it => it.SellerId == seller.Id).ToList();
            var model = properties.Select(mapper.Map);
            return View(model);
        }

        [Authorize(Roles = "Administrator,SellerOrAgent")]
        public ActionResult SubmitProperty()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,SellerOrAgent")]
        public async Task<ActionResult> SubmitProperty(SetPropertyViewModel model)
        {
            var seller = GetSeller();

            var (address, property, propertyDetail, propertyFeature) = mapper.Map(model, seller);

            if (model.PropertyMultimedia[0] != null)
            {
                foreach (var httpPostedFileBase in model.PropertyMultimedia)
                {
                    var photo = new Multimedia
                    {
                        FileName = httpPostedFileBase.FileName,
                        Content = httpPostedFileBase.SetContent(),
                        Link = new Url(model.Link),
                        Type = Enum.GetName(typeof(MultimediaType), MultimediaType.PropertyPhoto)
                    };

                    context.MultiMedias.Add(photo);
                    property.MultimediaIds += $"{photo.Id};";
                }
            }

            if (model.Blueprint[0] != null)
            {
                foreach (var httpPostedFileBase in model.Blueprint)
                {
                    var blueprint = new Multimedia
                    {
                        FileName = httpPostedFileBase.FileName,
                        Content = httpPostedFileBase.SetContent(),
                        Type = Enum.GetName(typeof(MultimediaType), MultimediaType.BlueprintPhoto)
                    };

                    context.MultiMedias.Add(blueprint);
                    property.MultimediaIds += $"{blueprint.Id}";
                }
            }

            if (model.Link != null)
            {
                var video = new Multimedia
                {
                    FileName = model.FileName,
                    Type = Enum.GetName(typeof(MultimediaType), MultimediaType.PropertyVideo),
                    Link = new Url(model.Link)
                };

                context.MultiMedias.Add(video);
                property.MultimediaIds += $"{video.Id}";
            }


            context.Addresses.Add(address);
            context.Properties.Add(property);
            context.PropertyDetails.Add(propertyDetail);
            context.PropertyFeatures.Add(propertyFeature);

            await context.SaveChangesAsync();

            return RedirectToAction("Properties4Seller", "Property");
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
    }
}