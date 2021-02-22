using System.ComponentModel.DataAnnotations;

namespace APFinal2202.ViewModels
{
    public class MultimediaViewModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        [Display(Name = "File Name")]
        [DataType(DataType.Text)]
        public string FileName { get; set; }

        [Display(Name = "Photo Type")]
        [DataType(DataType.Text)]
        public string PhotoType { get; set; }

        public string Image { get; set; }
    }
}