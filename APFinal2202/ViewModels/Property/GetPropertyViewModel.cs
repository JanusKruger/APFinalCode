using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APFinal2202.ViewModels.Property
{
    public class GetPropertyViewModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Title")]
        public string PropertyTitle { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Description")]
        public string PropertyDescription { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Type")]
        public string PropertyType { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Status")]
        public string PropertyStatus { get; set; }


        [DataType(DataType.Text)]
        [Display(Name = "Bedrooms")]
        public string Bedrooms { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Bathrooms")]
        public string Bathrooms { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Floor size")]
        public string FloorSize { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Erf size")]
        public string ErfSize { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Monthly Levies")]
        public string MonthlyLevies { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Rates &amp; Taxes")]
        public string RatesAndTaxes { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Special Levies")]
        public string SpecialLevies { get; set; }

        [Display(Name = "Borehole")]
        [DataType(DataType.Text)]
        public bool Borehole { get; set; }

        [Display(Name = "Built-in Cupboards")]
        [DataType(DataType.Text)]
        public bool BuiltInCupboards { get; set; }

        [Display(Name = "Carpets")]
        [DataType(DataType.Text)]
        public bool Carpets { get; set; }

        [Display(Name = "Carport")]
        [DataType(DataType.Text)]
        public bool Carport { get; set; }

        [Display(Name = "Domestic Bathroom")]
        [DataType(DataType.Text)]
        public bool DomesticBathroom { get; set; }

        [Display(Name = "Double Garage")]
        [DataType(DataType.Text)]
        public bool DoubleGarage { get; set; }

        [Display(Name = "Club house")]
        [DataType(DataType.Text)]
        public bool Clubhouse { get; set; }

        [Display(Name = "Fiber Internet")]
        [DataType(DataType.Text)]
        public bool FiberInternet { get; set; }

        [Display(Name = "Garage")]
        [DataType(DataType.Text)]
        public bool Garage { get; set; }

        [Display(Name = "Garden")]
        [DataType(DataType.Text)]
        public bool Garden { get; set; }

        [Display(Name = "Solar Power")]
        [DataType(DataType.Text)]
        public bool SolarPower { get; set; }

        [Display(Name = "Swimming Pool")]
        [DataType(DataType.Text)]
        public bool SwimmingPool { get; set; }

        [Display(Name = "Tiled Floors")]
        [DataType(DataType.Text)]
        public bool TiledFloors { get; set; }

        [Display(Name = "Visitor Parking")]
        [DataType(DataType.Text)]
        public bool VisitorParking { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Town")]
        public string Town { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Province")]
        public string Province { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Type of Photo")]
        public List<string> PhotoType { get; set; }

        [Display(Name = "Filename")]
        public List<string> FileName { get; set; }

        [Display(Name = "Image")]
        public List<string> Image { get; set; }


        [DataType(DataType.Text)]
        [Display(Name = "Opening Bid")]
        public string OpeningBid { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Auction Start Date")]
        public string AuctionStart { get; set; }


        [DataType(DataType.Text)]
        [Display(Name = "Auction End Date")]
        public string AuctionEnd { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Auction Type")]
        public string AuctionType { get; set; }
    }
}