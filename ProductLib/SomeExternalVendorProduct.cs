using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class SomeExternalVendorProduct
    {
        private int _pricePerUnit;
        private string _eanCode;
        private string _title;

        public int PricePerUnit
        {
            get { return (int)456; }
            set { _pricePerUnit = value; }
        }

        public string EANCode
        {
            get { return "987654321"; }
            set { _eanCode = value; }
        }

        public string Title
        {
            get { return "External Product Unit"; }
            set { _title = value; }
        }
    }
}
