using DevBackEnd.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBackEnd.DataAccess.Concrete.EntityFramework.Mappings
{
    public class DistrictMap:IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable(@"DISTRICTS", @"dbo");
            builder.HasKey(x => x.DistrictId);

            builder.Property(x => x.DistrictId).HasColumnName("ID");
            builder.Property(x => x.TownId).HasColumnName("TOWNID");
            builder.Property(x => x.DistrictName).HasColumnName("DISTRICT");
        }
    }
}
