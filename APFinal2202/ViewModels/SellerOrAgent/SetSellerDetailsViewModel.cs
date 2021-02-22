using System.ComponentModel.DataAnnotations;
using System.Web;

namespace APFinal2202.ViewModels.SellerOrAgent
{
    public class SetSellerDetailsViewModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Signature")]
        public bool Signature { get; set; }

        [Required]
        [Display(Name = "Approval Status")]
        public bool ApprovalStatus { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "Seller Type")]
        public string SellerType { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [Display(Name = "National ID")]
        public string NationalIdentificationNumber { get; set; }


        [Display(Name = "Do you want to receive our newsletter?")]
        public bool ReceiveNewsletter { get; set; }

        [Required]
        [Display(Name = "Do you agree with the terms and conditions?")]
        public bool TermsAndConditions { get; set; }

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

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Profile Photo")]
        public HttpPostedFileBase ProfilePhoto { get; set; }
    }
}