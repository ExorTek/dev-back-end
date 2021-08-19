using DevBackEnd.Core.DataAccess.EntityFramework;
using DevBackEnd.DataAccess.Abstract;
using DevBackEnd.Entities.Concrete;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDetailDal : EfEntityRepositoryBase<OrderDetail, ETradeContext>, IOrderDetailDal
    {
        public EfOrderDetailDal(ETradeContext context) : base(context)
        {
        }
    }
}