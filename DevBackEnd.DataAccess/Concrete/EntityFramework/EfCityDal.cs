using DevBackEnd.Core.DataAccess.EntityFramework;
using DevBackEnd.DataAccess.Abstract;
using DevBackEnd.Entities.Concrete;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework
{
    public class EfCityDal:EfEntityRepositoryBase<City,ETradeContext>,ICityDal
    {
        public EfCityDal(ETradeContext context) : base(context)
        {
        }
    }
}
