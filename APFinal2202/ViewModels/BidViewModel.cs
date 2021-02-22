using System.ComponentModel.DataAnnotations;

namespace APFinal2202.ViewModels
{
    public class BidViewModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Bid amount")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string Amount { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Time of the bidding")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public string TimeOf { get; set; }

        [Display(Name = "Is the bidding concluded?")]
        public bool IsConcluded { get; set; }
    }
}