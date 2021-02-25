using System.ComponentModel.DataAnnotations;

namespace APFinal2202.ViewModels.Buyer
{
    public class GetBuyerDetailsViewModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Signature")]
        public bool Signature { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Approval Status")]
        public bool ApprovalStatus { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Seller Type")]
        public string SellerType { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "National ID")]
        public string NationalIdentificationNumber { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Your choice for receiving our newsletter")]
        public bool ReceiveNewsletter { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Role")]
        public string Role { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

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

        [DataType(DataType.Text)]
        [Display(Name = "Type of Photo")]
        public string PhotoType { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Filename")]
        public string FileName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Image")]
        public string Image { get; set; }
    }
}