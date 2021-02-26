using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace APFinal2202.ViewModels.Property
{
    [Authorize(Roles = "Seller")]
    public class SetPropertyViewModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Title")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Description of the Property")]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Price (R)")]
        public string Price { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Property Type")]
        public string PropertyType { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Ownership Type")]
        public string OwnershipType { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Property Status")]
        public string PropertyStatus { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Property Photos (Max 8 Images)")]
        public HttpPostedFileBase[] PropertyMultimedia { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "File Name")]
        public string FileName { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Link")]
        public string Link { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Blueprint Plans")]
        public HttpPostedFileBase[] Blueprint { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "Suburb")]
        public string Suburb { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Bedrooms")]
        public string Bedrooms { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Bathrooms")]
        public string Bathrooms { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Floor Size (m²)")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string FloorSize { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Erf size (m²)")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string ErfSize { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Monthly Levies")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string MonthlyLevies { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Rates & Taxes")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string RatesAndTaxes { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Special Levies")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string SpecialLevies { get; set; }

        [Display(Name = "Air Conditioning")]
        public bool AirConditioning { get; set; }

        [Display(Name = "Balcony")]
        public bool Balcony { get; set; }


        [Display(Name = "Borehole")]
        public bool Borehole { get; set; }

        [Display(Name = "Built-in Braai")]
        public bool BuiltInBraai { get; set; }

        [Display(Name = "Built-in Cupboards")]
        public bool BuiltInCupboards { get; set; }

        [Display(Name = "Carpets")]
        public bool Carpets { get; set; }

        [Display(Name = "Carport")]
        public bool Carport { get; set; }

        [Display(Name = "Domestic Bathroom")]
        public bool DomesticBathroom { get; set; }

        [Display(Name = "Double Garage")]
        public bool DoubleGarage { get; set; }

        [Display(Name = "Clubhouse")]
        public bool Clubhouse { get; set; }

        [Display(Name = "FiberInternet")]
        public bool FiberInternet { get; set; }

        [Display(Name = "Garage")]
        public bool Garage { get; set; }

        [Display(Name = "Garden")]
        public bool Garden { get; set; }

        [Display(Name = "Pet Friendly")]
        public bool PetFriendly { get; set; }

        [Display(Name = "Solar Power")]
        public bool SolarPower { get; set; }

        [Display(Name = "Swimming Pool")]
        public bool SwimmingPool { get; set; }

        [Display(Name = "Tiled Floors")]
        public bool TiledFloors { get; set; }

        [Display(Name = "Visitor Parking")]
        public bool VisitorParking { get; set; }
    }
}