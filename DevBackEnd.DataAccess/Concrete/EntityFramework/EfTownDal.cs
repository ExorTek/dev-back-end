using DevBackEnd.Core.DataAccess.EntityFramework;
using DevBackEnd.DataAccess.Abstract;
using DevBackEnd.Entities.Concrete;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework
{
    public class EfTownDal : EfEntityRepositoryBase<Town, ETradeContext>, ITownDal
    {
        public EfTownDal(ETradeContext context) : base(context)
        {
        }
    }
}