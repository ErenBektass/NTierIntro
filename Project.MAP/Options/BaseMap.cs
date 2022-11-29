using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    //Bizim Veritabanında ayarlamaları yapmamızı saglayacak bir sınıf... Veritabanında ayarlamaları yapmamızı saglayan sınıf EntityTypeConfiguration isimli generic sınıftır...Kendisi EntityFramework kütüphanesi icerisinde bulunur...
    public abstract class BaseMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap()
        {

            //HasColumnName metodu ile ilgili property'nin SQL'deki sütun ismini belirliyoruz...
            Property(x => x.CreatedDate).HasColumnName("Veri Yaratma Tarihi");
            Property(x => x.ModifiedDate).HasColumnName("Veri Guncelleme Tarihi");
            Property(x => x.DeletedDate).HasColumnName("Veri Silme Tarihi");
            Property(x => x.Status).HasColumnName("Veri Durumu");
        }
    }
}
