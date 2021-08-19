using DevBackEnd.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable(@"CITIES",@"dbo");
            builder.HasKey(x => x.CityId);

            builder.Property(x => x.CityId).HasColumnName("ID");
            builder.Property(x => x.CountryId).HasColumnName("COUNTRYID");
            builder.Property(x => x.CityName).HasColumnName("CITY");
        }
    }
}