using DevBackEnd.Core.DataAccess.EntityFramework;
using DevBackEnd.DataAccess.Abstract;
using DevBackEnd.Entities.Concrete;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework
{
    public class EfInvoiceDetailDal:EfEntityRepositoryBase<InvoiceDetail,ETradeContext>,IInvoiceDetail
    {
        public EfInvoiceDetailDal(ETradeContext context) : base(context)
        {
        }
    }
}
