using DevBackEnd.Core.DataAccess.EntityFramework;
using DevBackEnd.DataAccess.Abstract;
using DevBackEnd.Entities.Concrete;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework
{
    public class EfCountryDal : EfEntityRepositoryBase<Country, ETradeContext>, ICountryDal
    {
        public EfCountryDal(ETradeContext context) : base(context)
        {
        }
    }
}