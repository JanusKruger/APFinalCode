using System.ComponentModel.DataAnnotations;

namespace APFinal2202.ViewModels.Property
{
    public class PropertyDetailViewModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Bedrooms")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]

        public string Bedrooms { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Bathrooms")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Bathrooms { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Floor size")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string FloorSize { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Erf size")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string ErfSize { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Monthly Levies")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string MonthlyLevies { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Rates &amp; Taxes")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string RatesAndTaxes { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Special Levies")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string SpecialLevies { get; set; }
    }
}