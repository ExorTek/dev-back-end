using DevBackEnd.DataAccess.Concrete.EntityFramework;
using DevBackEnd.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevBackEnd.DataAccess.Test.EntityFrameworkTest
{
    [TestClass]
    public class EntityFrameworkCityTest
    {
        [TestMethod]
        public void Get_all_returns_all_city()
        {
            //success
            EfCityDal cityDal = new EfCityDal(new ETradeContext());
            var result = cityDal.GetList();
            Assert.AreEqual(81, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_city()
        {
            //success
            EfCityDal cityDal = new EfCityDal(new ETradeContext());
            var result = cityDal.GetList(p => p.CityName.Contains("ab"));
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Will_the_city_be_added()
        {
            //success
            EfCityDal cityDal = new EfCityDal(new ETradeContext());
            var city = new City()
            {
                CityName = "Test",
                CountryId = 1
            };
            cityDal.Add(city);
        }

        [TestMethod]
        public void Deleted_the_city()
        {
            //success
            EfCityDal cityDal = new EfCityDal(new ETradeContext());
            var city = new City()
            {
                CityName = "Test",
                CountryId = 1
            };
            cityDal.Delete(city);
        }
    }
}