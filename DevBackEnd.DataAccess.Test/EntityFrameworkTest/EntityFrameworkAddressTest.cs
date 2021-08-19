using DevBackEnd.DataAccess.Concrete.EntityFramework;
using DevBackEnd.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevBackEnd.DataAccess.Test.EntityFrameworkTest
{
    [TestClass]
    public class EntityFrameworkAddressTest
    {
        [TestMethod]
        public void Get_all_returns_all_address()
        {
            //success
            EfAddressDal addressDal = new EfAddressDal(new ETradeContext());
            var result = addressDal.GetList();
            Assert.AreEqual(25051,result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_address()
        {
            //success
            EfAddressDal productDal = new EfAddressDal(new ETradeContext());
            var result = productDal.GetList(p => p.AddressText.Contains("ab"));
            Assert.AreEqual(1438, result.Count);
        }
        [TestMethod]
        public void Will_the_product_be_added()
        {
            //success
            EfAddressDal productDal = new EfAddressDal(new ETradeContext());
            var address = new Address()
            {
                AddressText = "afasfasfaf",
                CityId = 1,
                CountryId = 1,
                TownId = 1,
                DistrictId = 1,
                PostalCode = "ADA",
                UserId = 1
            };
            productDal.Add(address);
        }
        [TestMethod]
        public void Deleted_the_address()
        {
            //success
            EfAddressDal productDal = new EfAddressDal(new ETradeContext());
            var address = new Address()
            {
                AddressText = "afasfasfaf",
                CityId = 1,
                CountryId = 1,
                TownId = 1,
                DistrictId = 1,
                PostalCode = "ADA",
                UserId = 1
            };
            productDal.Delete(address);
        }
    }
}
