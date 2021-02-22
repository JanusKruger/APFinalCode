using System.ComponentModel.DataAnnotations;
using System.Web;

namespace APFinal2202.ViewModels.Property
{
    public class PropertyViewModel
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
        [Display(Name = "Description")]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Property Type")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string PropertyType { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Ownership Type")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string OwnershipType { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Property Status")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string PropertyStatus { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Property Photos And Videos")]
        public HttpPostedFileBase PropertyMultimedia { get; set; }


        [DataType(DataType.Upload)]
        [Display(Name = "Blueprint Plans")]
        public HttpPostedFileBase Blueprint { get; set; }
    }
}