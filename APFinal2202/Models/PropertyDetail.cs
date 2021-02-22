using System;
using System.Collections.Generic;

namespace APFinal2202.Models
{
    public class PropertyDetail
    {
        public PropertyDetail()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Bedrooms { get; set; }

        public string Bathrooms { get; set; }

        public double FloorSize { get; set; }

        public double ErfSize { get; set; }

        public double MonthlyLevies { get; set; }

        public double RatesAndTaxes { get; set; }

        public double SpecialLevies { get; set; }

        public List<string> Features { get; set; }

        public string PropertyId { get; set; }

    }
}