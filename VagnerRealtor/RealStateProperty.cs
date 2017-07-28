using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VagnerRealtor
{
    [Serializable]
    public class RealStateProperty
    {

        public string PropertyNumber { get; set; }
        public string PropertyType { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIPCode { get; set; }
        public short Stories { get; set; }
        public int YearBuilt { get; set; }
        public short Bedrooms { get; set; }
        public float Bathrooms { get; set; }
        public string Condition { get; set; }
        public string SaleStatus { get; set; }
        public double MarketValue { get; set; }
        public string PictureFile { get; set; }

        // To determine that two properties are the same,
        // we will test only the property number.
        // We assume that if two properties have the same number,
        // then it is the same property
        public override bool Equals(object obj)
        {
            RealStateProperty rep = (RealStateProperty)obj;

            if (rep.PropertyNumber == PropertyNumber)
                return true;
            else
                return false;
        }

        // To avoid a compiler warning
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
