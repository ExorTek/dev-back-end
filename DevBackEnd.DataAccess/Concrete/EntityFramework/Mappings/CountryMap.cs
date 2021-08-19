using DevBackEnd.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework.Mappings
{
   public class CountryMap:IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable(@"COUNTRIES", @"dbo");
            builder.HasKey(x => x.CountryId);

            builder.Property(x => x.CountryId).HasColumnName("ID");
            builder.Property(x => x.CountryName).HasColumnName("COUNTRY");
        }
    }
}
