using DevBackEnd.DataAccess.Concrete.EntityFramework;
using DevBackEnd.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevBackEnd.DataAccess.Test.EntityFrameworkTest
{
    [TestClass]
    public class EntityFrameworkProductTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            //success
            EfProductDal productDal = new EfProductDal(new ETradeContext());
            var result = productDal.GetList();
            Assert.AreEqual(28067, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_product()
        {
            //success
            EfProductDal productDal = new EfProductDal(new ETradeContext());
            var result = productDal.GetList(p => p.ProductName.Contains("ab"));
            Assert.AreEqual(2056, result.Count);
        }

        [TestMethod]
        public void Will_the_address_be_added()
        {
            //success
            EfProductDal productDal = new EfProductDal(new ETradeContext());
            var product = new Product()
            {
                ProductName = "Laptop",
                UnitPrice = 12,
                Category1 = "Elektronik",
                Category2 = "Tablet/Bilgisayar",
                Category3 = "Dizüstü Bilgisayar",
                Category4 = "Gaming Laptop",
                Brand = "Asus",
                ProductCode = "589"
            };
            productDal.Add(product);
        }

        [TestMethod]
        public void deleted_the_product()
        {
            //success
            EfProductDal productDal = new EfProductDal(new ETradeContext());
            var product = new Product()
            {
                ProductName = "Laptop",
                UnitPrice = 12,
                Category1 = "Elektronik",
                Category2 = "Tablet/Bilgisayar",
                Category3 = "Dizüstü Bilgisayar",
                Category4 = "Gaming Laptop",
                Brand = "Asus",
                ProductCode = "589"
            };
            productDal.Delete(product);
        }
    }
}