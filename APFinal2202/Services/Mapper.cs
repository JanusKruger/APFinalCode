using APFinal2202.Contracts;
using APFinal2202.Enums;
using APFinal2202.Helpers;
using APFinal2202.Models;
using APFinal2202.ViewModels;
using APFinal2202.ViewModels.Account;
using APFinal2202.ViewModels.Buyer;
using APFinal2202.ViewModels.Property;
using APFinal2202.ViewModels.SellerOrAgent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APFinal2202.Services
{
    public class Mapper : IMapper
    {
        public ApplicationUser Map(RegisterViewModel model)
        {
            var user = new ApplicationUser
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                NationalIdentificationNumber = model.NationalIdentificationNumber,
                UserName = model.Email,
                PasswordHash = model.Password,
                PhoneNumber = model.PhoneNumber,
                Role = model.UserType.TrimSpaces(),
                ReceiveNewsletter = model.ReceiveNewsletter
            };

            return user;
        }

        public GetSellerDetailsViewModel Map(Seller seller, ApplicationUser user, Address address, Multimedia multimedia)
        {
            var model = new GetSellerDetailsViewModel
            {
                Id = seller.Id,
                Signature = seller.Signature,
                ApprovalStatus = seller.ApprovalStatus,
                SellerType = seller.SellerType,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.UserName,
                Email = user.Email,
                Role = user.Role,
                PhoneNumber = user.PhoneNumber,
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                Town = address.Town,
                Province = address.Province,
                PostalCode = address.PostalCode,
                Country = address.Country,
                PhotoType = multimedia.Type.Humanize(),
                FileName = multimedia.FileName.RemoveExtension(),
                Image = multimedia.Content.GetContent()
            };
            return model;
        }

        public GetBuyerDetailsViewModel Map(Buyer buyer, ApplicationUser user, Address address, Multimedia multimedia)
        {
            var model = new GetBuyerDetailsViewModel
            {
                Id = buyer.Id,
                Signature = buyer.Signature,
                ApprovalStatus = buyer.ApprovalStatus,
                SellerType = buyer.BuyerType,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.UserName,
                Email = user.Email,
                Role = user.Role,
                PhoneNumber = user.PhoneNumber,
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                Town = address.Town,
                Province = address.Province,
                PostalCode = address.PostalCode,
                Country = address.Country,
                PhotoType = multimedia.Type.Humanize(),
                FileName = multimedia.FileName.RemoveExtension(),
                Image = multimedia.Content.GetContent()
            };
            return model;
        }

        public Tuple<Multimedia, Address, Seller> Map(SetSellerDetailsViewModel model, string userId)
        {
            var multimedia = new Multimedia
            {
                FileName = model.ProfilePhoto.FileName,
                Content = model.ProfilePhoto.SetContent(),
                Type = Enum.GetName(typeof(MultimediaType), MultimediaType.ProfilePhoto)
            };

            var address = new Address
            {
                AddressLine1 = model.AddressLine1,
                AddressLine2 = model.AddressLine2,
                Town = model.Town,
                Province = model.Province,
                PostalCode = model.PostalCode,
                Country = model.Country
            };

            var seller = new Seller
            {
                Signature = model.Signature,
                ApprovalStatus = model.ApprovalStatus,
                SellerType = model.SellerType,
                UserId = userId,
                AddressId = address.Id,
                MultimediaId = multimedia.Id
            };

            return new Tuple<Multimedia, Address, Seller>(multimedia, address, seller);
        }

        public Tuple<Multimedia, Address, Buyer> Map(SetDetailsBuyerViewModel model, string userId)
        {
            var multimedia = new Multimedia
            {
                FileName = model.ProfilePhoto.FileName,
                Content = model.ProfilePhoto.SetContent(),
                Type = Enum.GetName(typeof(MultimediaType), MultimediaType.ProfilePhoto)
            };

            var address = new Address
            {
                AddressLine1 = model.AddressLine1,
                AddressLine2 = model.AddressLine2,
                Town = model.Town,
                Province = model.Province,
                PostalCode = model.PostalCode,
                Country = model.Country
            };

            var buyer = new Buyer
            {
                Signature = model.Signature,
                ApprovalStatus = model.ApprovalStatus,
                BuyerType = model.BuyerType.GetName<BuyerType>(),
                UserId = userId,
                AddressId = address.Id,
                MultimediaId = multimedia.Id
            };

            return new Tuple<Multimedia, Address, Buyer>(multimedia, address, buyer);
        }

        public Tuple<Address, Property, PropertyDetail, PropertyFeature> Map(SetPropertyViewModel model, Seller seller)
        {
            var address = new Address
            {
                AddressLine1 = model.AddressLine1,
                AddressLine2 = model.AddressLine2,
                Town = model.City,
                Province = model.Suburb,
                PostalCode = model.PostalCode,
                Country = model.Country
            };

            var property = new Property
            {
                Title = model.Title,
                Description = model.Description,
                PropertyType = model.PropertyType,
                OwnershipType = model.OwnershipType,
                PropertyStatus = model.PropertyStatus,
                AddressId = address.Id,
                SellerId = seller.Id,
            };


            var details = new PropertyDetail
            {
                Bathrooms = model.Bathrooms,
                Bedrooms = model.Bedrooms,
                FloorSize = model.FloorSize.GetDouble(),
                ErfSize = model.ErfSize.GetDouble(),
                MonthlyLevies = model.MonthlyLevies.GetDouble(),
                RatesAndTaxes = model.RatesAndTaxes.GetDouble(),
                SpecialLevies = model.SpecialLevies.GetDouble(),
                PropertyId = property.Id
            };

            var features = new PropertyFeature
            {
                AirConditioning = model.AirConditioning,
                Balcony = model.Balcony,
                Borehole = model.Borehole,
                BuiltInBraai = model.BuiltInBraai,
                BuiltInCupboards = model.BuiltInCupboards,
                Carpets = model.Carpets,
                Carport = model.Carport,
                DomesticBathroom = model.DomesticBathroom,
                DoubleGarage = model.DoubleGarage,
                Clubhouse = model.Clubhouse,
                FiberInternet = model.FiberInternet,
                Garage = model.Garage,
                Garden = model.Garden,
                PetFriendly = model.PetFriendly,
                SolarPower = model.SolarPower,
                SwimmingPool = model.SwimmingPool,
                TiledFloors = model.TiledFloors,
                VisitorParking = model.VisitorParking,
                PropertyId = property.Id
            };

            return new Tuple<Address, Property, PropertyDetail, PropertyFeature>(address, property, details, features);
        }

        public List<GetPropertyViewModel> Map(Tuple<List<Property>, List<PropertyDetail>, List<PropertyFeature>, List<Address>, List<Multimedia>, List<Auction>> tuple)
        {
            var model = new List<GetPropertyViewModel>();

            // ReSharper disable once ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
            foreach (var property in tuple.Item1)
            {
                var detail = tuple.Item2.FirstOrDefault(it => it.PropertyId == property.Id);
                var feature = tuple.Item3.FirstOrDefault(it => it.PropertyId == property.Id);
                var address = tuple.Item4.FirstOrDefault(it => it.Id == property.AddressId);
                var multimedia = GetMultimedia(tuple.Item5, property);
                var auction = tuple.Item6.FirstOrDefault(it => it.PropertyId == property.Id);


                var item = new GetPropertyViewModel
                {
                    FileName = new List<string>(),
                    PhotoType = new List<string>(),
                    Image = new List<string>(),
                    Id = property.Id,
                    PropertyTitle = property.Title,
                    PropertyDescription = property.Description,
                    PropertyType = property.PropertyType,
                    PropertyStatus = property.PropertyStatus,
                    Town = address.Town,
                    Province = address.Province,
                    Country = address.Country,
                    Borehole = feature.Borehole,
                    BuiltInCupboards = feature.BuiltInCupboards,
                    Carpets = feature.Carpets,
                    Carport = feature.Carport,
                    DomesticBathroom = feature.DomesticBathroom,
                    DoubleGarage = feature.DoubleGarage,
                    Clubhouse = feature.Clubhouse,
                    FiberInternet = feature.FiberInternet,
                    Garage = feature.Garage,
                    Garden = feature.Garden,
                    SolarPower = feature.SolarPower,
                    SwimmingPool = feature.SwimmingPool,
                    TiledFloors = feature.TiledFloors,
                    VisitorParking = feature.VisitorParking,
                    Bathrooms = detail.Bathrooms,
                    Bedrooms = detail.Bedrooms,
                    ErfSize = detail.ErfSize.ToString("F"),
                    FloorSize = detail.FloorSize.ToString("F"),
                    MonthlyLevies = detail.MonthlyLevies.ToString("C"),
                    SpecialLevies = detail.SpecialLevies.ToString("C"),
                    RatesAndTaxes = detail.RatesAndTaxes.ToString("C")
                };

                foreach (var singleItem in multimedia.Where(singleItem => singleItem != null))
                {
                    item.FileName.Add(singleItem.FileName.RemoveExtension());
                    item.PhotoType.Add(singleItem.Type.Humanize());
                    item.Image.Add(singleItem.Content.GetContent());
                }


                if (auction != null)
                {
                    item.AuctionType = auction.AuctionType;
                    item.AuctionStart = auction.AuctionStart.ToString("G");
                    item.AuctionEnd = auction.AuctionEnd.ToString("G");
                }
                model.Add(item);
            }

            return model;
        }

        public PropertyViewModel Map(Property property)
        {
            var model = new PropertyViewModel
            {
                Id = property.Id,
                Title = property.Title,
                Description = property.Description,
                PropertyType = property.PropertyType,
                PropertyStatus = property.PropertyStatus,
                OwnershipType = property.OwnershipType
            };

            return model;
        }

        public Auction Map(AuctionViewModel model, string auctionedPropertyId)
        {
            return new Auction
            {
                OpeningBid = model.OpeningBid.GetDouble(),
                AuctionStart = model.AuctionStart.GetDateTime(),
                AuctionEnd = model.AuctionEnd.GetDateTime(),
                AuctionType = model.AuctionType,
                PropertyId = auctionedPropertyId
            };
        }

        public Bid Map(BidViewModel model, string propertyId, string buyerId)
        {
            return new Bid
            {
                Amount = model.Amount.GetDouble(),
                TimeOf = model.TimeOf.GetDateTime(),
                IsConcluded = model.IsConcluded,
                PropertyId = propertyId,
                BuyerId = buyerId
            };
        }

        //

        private static List<Multimedia> GetMultimedia(IReadOnlyCollection<Multimedia> multiMedias, Property property)
        {
            if (string.IsNullOrEmpty(property.MultimediaIds))
            {
                return new List<Multimedia>();
            }

            var multimediaIds = property.MultimediaIds.Split(';');
            var multimedia = multimediaIds
                .Select(multimediaId => multiMedias.FirstOrDefault(it => it.Id == multimediaId))
                .ToList();
            return multimedia;
        }
    }
}