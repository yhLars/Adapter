using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Product : IProduct
    {
        private decimal _unitPrice;
        private string _barCode;
        private string _title;

        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        public string BarCode
        {
            get { return _barCode; }
            set { _barCode = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}
