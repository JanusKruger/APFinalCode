using System.ComponentModel.DataAnnotations;

namespace APFinal2202.ViewModels.Property
{
    public class PropertyFeatureViewModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        [Display(Name = "Borehole")]
        [DataType(DataType.Text)]
        public bool Borehole { get; set; }

        [Display(Name = "Built-in Cupboards")]
        [DataType(DataType.Text)]
        public bool BuiltInCupboards { get; set; }

        [Display(Name = "Carpets")]
        [DataType(DataType.Text)]
        public bool Carpets { get; set; }

        [Display(Name = "Carport")]
        [DataType(DataType.Text)]
        public bool Carport { get; set; }

        [Display(Name = "Domestic Bathroom")]
        [DataType(DataType.Text)]
        public bool DomesticBathroom { get; set; }

        [Display(Name = "Double Garage")]
        [DataType(DataType.Text)]
        public bool DoubleGarage { get; set; }

        [Display(Name = "Club house")]
        [DataType(DataType.Text)]
        public bool Clubhouse { get; set; }

        [Display(Name = "Fiber Internet")]
        [DataType(DataType.Text)]
        public bool FiberInternet { get; set; }

        [Display(Name = "Garage")]
        [DataType(DataType.Text)]
        public bool Garage { get; set; }

        [Display(Name = "Garden")]
        [DataType(DataType.Text)]
        public bool Garden { get; set; }

        [Display(Name = "Solar Power")]
        [DataType(DataType.Text)]
        public bool SolarPower { get; set; }

        [Display(Name = "Swimming Pool")]
        [DataType(DataType.Text)]
        public bool SwimmingPool { get; set; }

        [Display(Name = "Tiled Floors")]
        [DataType(DataType.Text)]
        public bool TiledFloors { get; set; }

        [Display(Name = "Visitor Parking")]
        [DataType(DataType.Text)]
        public bool VisitorParking { get; set; }
    }
}