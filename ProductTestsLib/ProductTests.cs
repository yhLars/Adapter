using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductAdapterLib;
using ProductLib;

namespace ProductTestsLib
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void TestProduct()
        {
            // ARRANGE
            decimal expectedUnitPrice = (decimal)123.45;
            string expectedBarCode = "123456789";
            string expectedTitle = "Product Unit";

            // ACT
            IProduct product = new Product();

            // ASSERT
            Assert.AreEqual(expectedBarCode, product.BarCode);
            Assert.AreEqual(expectedTitle, product.Title);
            Assert.AreEqual(expectedUnitPrice, product.UnitPrice);
        }

        [TestMethod]
        public void TestExternalProduct()
        {
            // ARRANGE
            int expectedPricePerUnit = 456;
            string expectedEANCode = "987654321";
            string expectedTitle = "External Product Unit";

            SomeExternalVendorProduct someExternalVendorProduct = new SomeExternalVendorProduct();

            // ACT
            IProduct product = new SomeExternalVendorProductAdapter(someExternalVendorProduct);

            // ASSERT
            Assert.AreEqual(expectedEANCode, product.BarCode);
            Assert.AreEqual(expectedTitle, product.Title);
            Assert.AreEqual(expectedPricePerUnit, product.UnitPrice);
        }
    }
}
