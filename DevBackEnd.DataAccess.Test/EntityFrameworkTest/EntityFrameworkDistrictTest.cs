using DevBackEnd.DataAccess.Concrete.EntityFramework;
using DevBackEnd.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevBackEnd.DataAccess.Test.EntityFrameworkTest
{
    [TestClass]
    public class EntityFrameworkDistrictTest
    {
        [TestMethod]
        public void Get_all_returns_all_district()
        {
            //success
            EfDistrictDal districtDal = new EfDistrictDal(new ETradeContext());
            var result = districtDal.GetList();
            Assert.AreEqual(53145,result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_district()
        {
            //success
            EfDistrictDal districtDal = new EfDistrictDal(new ETradeContext());
            var result = districtDal.GetList(p => p.DistrictName.Contains("ab"));
            Assert.AreEqual(1280, result.Count);
        }
        [TestMethod]
        public void Will_the_district_be_district()
        {
            //success
            EfDistrictDal districtDal = new EfDistrictDal(new ETradeContext());
            var district = new District()
            {
               DistrictName = "Test",
               TownId = 1
            };
            districtDal.Add(district);
        }
        [TestMethod]
        public void Deleted_the_district()
        {
            //success
            EfDistrictDal districtDal = new EfDistrictDal(new ETradeContext());
            var district = new District()
            {
                DistrictName = "Test",
                TownId = 1
            };
            districtDal.Delete(district);
        }
    }
}
