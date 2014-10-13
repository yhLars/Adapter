namespace ProductLib
{
    public class Product : IProduct
    {
        private decimal _unitPrice;
        private string _barCode;
        private string _title;

        public decimal UnitPrice
        {
            get { return (decimal)123.45; }
            set { _unitPrice = value; }
        }

        public string BarCode
        {
            get { return "123456789"; }
            set { _barCode = value; }
        }

        public string Title
        {
            get { return "Product Unit"; }
            set { _title = value; }
        }
    }
}
