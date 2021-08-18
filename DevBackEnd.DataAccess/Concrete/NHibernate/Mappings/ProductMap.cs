using DevBackEnd.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DevBackEnd.DataAccess.Concrete.NHibernate.Mappings
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"ITEMS");
            LazyLoad();
            Id(x => x.ProductId).Column("ID").Not.Nullable();
            Map(x => x.ProductCode).Column("ITEMCODE").Length(50);
            Map(x => x.ProductName).Column("ITEMNAME").Length(50);
            Map(x => x.UnitPrice).Column("UNITPRICE");
            Map(x => x.Category1).Column("CATEGORY1").Length(100);
            Map(x => x.Category2).Column("CATEGORY2").Length(100);
            Map(x => x.Category3).Column("CATEGORY3").Length(100);
            Map(x => x.Category4).Column("CATEGORY4").Length(100);
            Map(x => x.Brand).Column("BRAND").Length(50);
        }
    }
}
