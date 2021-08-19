using DevBackEnd.Core.DataAccess.EntityFramework;
using DevBackEnd.DataAccess.Abstract;
using DevBackEnd.Entities.Concrete;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework
{
    public class EfAddressDal : EfEntityRepositoryBase<Address, ETradeContext>, IAddressDal
    {
        public EfAddressDal(ETradeContext context) : base(context)
        {
        }
    }
}