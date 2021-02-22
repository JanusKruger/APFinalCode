using System.ComponentModel.DataAnnotations;

namespace APFinal2202.ViewModels
{
    public class AuctionViewModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Opening Bid")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string OpeningBid { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Auction Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string AuctionStart { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Auction End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string AuctionEnd { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Auction Type")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string AuctionType { get; set; }

    }
}