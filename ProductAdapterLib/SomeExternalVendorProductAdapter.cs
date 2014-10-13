﻿using ProductLib;

namespace ProductAdapterLib
{
    public class SomeExternalVendorProductAdapter : IProduct
    {
        private decimal _unitPrice;
        private string _barCode;
        private string _title;

        public SomeExternalVendorProductAdapter(SomeExternalVendorProduct someExternalVendorProduct)
        {
            _unitPrice = someExternalVendorProduct.PricePerUnit;
            _barCode = someExternalVendorProduct.EANCode;
            _title = someExternalVendorProduct.Title;
        }

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
