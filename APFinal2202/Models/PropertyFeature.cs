using System;

namespace APFinal2202.Models
{
    public class PropertyFeature
    {
        public PropertyFeature()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public bool AirConditioning { get; set; }

        public bool Balcony { get; set; }

        public bool Borehole { get; set; }

        public bool BuiltInBraai { get; set; }

        public bool BuiltInCupboards { get; set; }

        public bool Carpets { get; set; }

        public bool Carport { get; set; }

        public bool DomesticBathroom { get; set; }

        public bool DoubleGarage { get; set; }

        public bool Clubhouse { get; set; }

        public bool FiberInternet { get; set; }

        public bool Garage { get; set; }

        public bool Garden { get; set; }

        public bool PetFriendly { get; set; }

        public bool SolarPower { get; set; }

        public bool SwimmingPool { get; set; }

        public bool TiledFloors { get; set; }

        public bool VisitorParking { get; set; }

        public string PropertyId { get; set; }
    }
}