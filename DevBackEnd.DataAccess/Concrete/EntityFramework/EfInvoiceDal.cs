using DevBackEnd.Core.DataAccess.EntityFramework;
using DevBackEnd.DataAccess.Abstract;
using DevBackEnd.Entities.Concrete;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework
{
    public class EfInvoiceDal:EfEntityRepositoryBase<Invoice,ETradeContext>,IInvoiceDal
    {
        public EfInvoiceDal(ETradeContext context) : base(context)
        {
        }
    }
}
