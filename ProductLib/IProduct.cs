namespace ProductLib
{
    public interface IProduct
    {
        decimal UnitPrice { get; set; }
        string BarCode { get; set; }
        string Title { get; set; }
    }
}
