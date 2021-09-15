using System;
using DevBackEnd.DataAccess.Concrete.EntityFramework;
using DevBackEnd.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevBackEnd.DataAccess.Test.EntityFrameworkTest
{
    [TestClass]
   public class EntityFrameworkInvoiceTest
    {
        [TestMethod]
        public void Get_all_returns_all_invoice()
        {
            //success
            EfInvoiceDal invoiceDal = new EfInvoiceDal(new ETradeContext());
            var result = invoiceDal.GetList();
            Assert.AreEqual(101259, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_invoice()
        {
            //success
            EfInvoiceDal invoiceDal = new EfInvoiceDal(new ETradeContext());
            var result = invoiceDal.GetList(p => p.InvoiceDate.ToString().Contains("2020"));
            Assert.AreEqual(19546, result.Count);
        }
        [TestMethod]
        public void Will_the_invoice_be_added()
        {
            //success
            EfInvoiceDal invoiceDal = new EfInvoiceDal(new ETradeContext());
            var invoice = new Invoice()
            {
                TotalPrice = 158,
                CargoFicheNo = "QWE123",
                InvoiceDate = DateTime.Now,
                InvoiceId = 1,
                OrderId = 1
            };
            invoiceDal.Add(invoice);
        }
        [TestMethod]
        public void Deleted_the_invoice()
        {
            //success
            EfInvoiceDal invoiceDal = new EfInvoiceDal(new ETradeContext());
            var invoice = new Invoice()
            {
                TotalPrice = 158,
                CargoFicheNo = "QWE123",
                InvoiceDate = DateTime.Now,
                InvoiceId = 1,
                OrderId = 1
            };
            invoiceDal.Delete(invoice);
        }
    }
}
