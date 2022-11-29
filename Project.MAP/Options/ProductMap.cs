using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    //Bu sınıfın görevi Product Class'ı tabloya dönüsecekken istedigimiz ayarlamaları yapmaktır
    public class ProductMap:BaseMap<Product>
    {
        public ProductMap()
        {
            ToTable("Urunler");
            Property(x => x.ProductName).HasColumnName("Urun Ismi");
            Property(x => x.UnitPrice).HasColumnName("Fiyat").HasColumnType("money");
        }
    }
}
