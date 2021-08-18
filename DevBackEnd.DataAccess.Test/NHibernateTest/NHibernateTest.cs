using DevBackEnd.DataAccess.Concrete.EntityFramework;
using DevBackEnd.DataAccess.Concrete.NHibernate;
using DevBackEnd.DataAccess.Concrete.NHibernate.Helper;
using DevBackEnd.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevBackEnd.DataAccess.Test.NHibernateTest
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            //success
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());
            var result = productDal.GetList();
            Assert.AreEqual(28067, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_product()
        {
            //success
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());
            var result = productDal.GetList(p => p.ProductName.Contains("ab"));
            Assert.AreEqual(2056, result.Count);
        }

        [TestMethod]
        public void Will_the_product_be_added()
        {
            //success
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());
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
    }
}