using DevBackEnd.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(@"ITEMS", @"dbo");
            builder.HasKey(x => x.ProductId);

            builder.Property(x => x.ProductId).HasColumnName("ID");
            builder.Property(x => x.ProductCode).HasColumnName("ITEMCODE");
            builder.Property(x => x.ProductName).HasColumnName("ITEMNAME");
            builder.Property(x => x.UnitPrice).HasColumnName("UNITPRICE");
            builder.Property(x => x.Category1).HasColumnName("CATEGORY1");
            builder.Property(x => x.Category2).HasColumnName("CATEGORY2");
            builder.Property(x => x.Category3).HasColumnName("CATEGORY3");
            builder.Property(x => x.Category4).HasColumnName("CATEGORY4");
            builder.Property(x => x.Brand).HasColumnName("BRAND");
        }
    }
}