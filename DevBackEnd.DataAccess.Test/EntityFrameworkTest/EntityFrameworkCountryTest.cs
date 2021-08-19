using DevBackEnd.DataAccess.Concrete.EntityFramework;
using DevBackEnd.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevBackEnd.DataAccess.Test.EntityFrameworkTest
{
    [TestClass]
    public class EntityFrameworkCountryTest
    {
        [TestMethod]
        public void Get_all_returns_all_country()
        {
            //success
            EfCountryDal productDal = new EfCountryDal(new ETradeContext());
            var result = productDal.GetList();
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_country()
        {
            //success
            EfCountryDal productDal = new EfCountryDal(new ETradeContext());
            var result = productDal.GetList(p => p.CountryName.Contains("ab"));
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void Will_the_country_be_added()
        {
            //success
            EfCountryDal productDal = new EfCountryDal(new ETradeContext());
            var country = new Country()
            {
                CountryName = "UNITED STATES"
            };
            productDal.Add(country);
        }

        [TestMethod]
        public void Deleted_the_country()
        {
            //success
            EfCountryDal productDal = new EfCountryDal(new ETradeContext());
            var country = new Country()
            {
                CountryName = "UNITED STATES"
            };
            productDal.Delete(country);
        }
    }
}