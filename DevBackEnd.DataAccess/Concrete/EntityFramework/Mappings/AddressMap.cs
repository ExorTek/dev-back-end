using DevBackEnd.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AddressMap:IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {

            builder.ToTable(@"ADDRESS", @"dbo");
            builder.HasKey(x => x.AddressId);

            builder.Property(x => x.AddressId).HasColumnName("ID");
            builder.Property(x => x.UserId).HasColumnName("USERID");
            builder.Property(x => x.CountryId).HasColumnName("COUNTRYID");
            builder.Property(x => x.CityId).HasColumnName("CITYID");
            builder.Property(x => x.TownId).HasColumnName("TOWNID");
            builder.Property(x => x.DistrictId).HasColumnName("DISTRICTID");
            builder.Property(x => x.PostalCode).HasColumnName("POSTALCODE");
            builder.Property(x => x.AddressText).HasColumnName("ADDRESSTEXT");
        }
    }
}
