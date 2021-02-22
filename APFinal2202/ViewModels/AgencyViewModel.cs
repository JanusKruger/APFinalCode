using System.ComponentModel.DataAnnotations;

namespace APFinal2202.ViewModels
{
    public class AgencyViewModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        public string Logo { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        public string PhoneNumber { get; set; }
    }
}
