using DevBackEnd.Core.DataAccess.EntityFramework;
using DevBackEnd.DataAccess.Abstract;
using DevBackEnd.Entities.Concrete;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework
{
    public class EfPaymentDal : EfEntityRepositoryBase<Payment, ETradeContext>, IPaymentDal
    {
        public EfPaymentDal(ETradeContext context) : base(context)
        {
        }
    }
}