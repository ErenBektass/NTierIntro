using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Kullanicilar");
            Property(x => x.UserName).HasColumnName("Kullanici Ismi");
            Property(x => x.Password).HasColumnName("Sifre");
            //Birebir ilişkinin tamamlanması
            HasOptional(x => x.Profile).WithRequired(x => x.AppUser);
        }
    }
}
