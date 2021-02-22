using APFinal2202.Models;
using APFinal2202.ViewModels;
using APFinal2202.ViewModels.Account;
using APFinal2202.ViewModels.Buyer;
using APFinal2202.ViewModels.Property;
using APFinal2202.ViewModels.SellerOrAgent;
using System;
using System.Collections.Generic;

namespace APFinal2202.Contracts
{
    public interface IMapper
    {
        ApplicationUser Map(RegisterViewModel model);

        GetSellerDetailsViewModel Map(Seller seller, ApplicationUser user, Address address, Multimedia multimedia);

        GetBuyerDetailsViewModel Map(Buyer buyer, ApplicationUser user, Address address, Multimedia multimedia);

        Tuple<Multimedia, Address, Seller> Map(SetSellerDetailsViewModel model, string userId);

        Tuple<Multimedia, Address, Buyer> Map(SetDetailsBuyerViewModel model, string userId);

        Tuple<Address, Property, PropertyDetail, PropertyFeature> Map(SetPropertyViewModel model, Seller seller);

        List<GetPropertyViewModel> Map(Tuple<List<Property>, List<PropertyDetail>, List<PropertyFeature>, List<Address>, List<Multimedia>, List<Auction>> tuple);

        PropertyViewModel Map(Property property);

        Auction Map(AuctionViewModel model, string propertyId);

        Bid Map(BidViewModel model, string propertyId, string buyerId);
    }
}
