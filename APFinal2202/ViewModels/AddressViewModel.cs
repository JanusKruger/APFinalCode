using System.ComponentModel.DataAnnotations;

namespace APFinal2202.ViewModels
{
    public class AddressViewModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

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
        [Display(Name = "Town")]
        public string Town { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "Province")]
        public string Province { get; set; }

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

    }
}