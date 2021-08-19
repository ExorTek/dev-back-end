using DevBackEnd.Core.DataAccess.EntityFramework;
using DevBackEnd.DataAccess.Abstract;
using DevBackEnd.Entities.Concrete;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework
{
   public class EfDistrictDal:EfEntityRepositoryBase<District,ETradeContext>,IDistrictDal
    {
        public EfDistrictDal(ETradeContext context) : base(context)
        {
        }
    }
}
