using DevBackEnd.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework.Mappings
{
    public class InvoiceMap : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable(@"INVOICES", @"dbo");
            builder.HasKey(x => x.InvoiceId);

            builder.Property(x => x.InvoiceId).HasColumnName("ID");
            builder.Property(x => x.OrderId).HasColumnName("ORDERID");
            builder.Property(x => x.InvoiceDate).HasColumnName("DATE_");
            builder.Property(x => x.AddressId).HasColumnName("ADDRESSID");
            builder.Property(x => x.CargoFicheNo).HasColumnName("CARGOFICHENO");
            builder.Property(x => x.TotalPrice).HasColumnName("TOTALPRICE");
        }
    }
}