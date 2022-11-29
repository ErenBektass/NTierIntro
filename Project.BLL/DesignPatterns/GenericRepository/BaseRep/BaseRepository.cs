using Project.BLL.DesignPatterns.GenericRepository.IntRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.BaseRep
{
    //Entity Framework Teknolojisi icin IRepository'deki metotlarımız implement edilecek...
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected MyContext _db;

        public BaseRepository()
        {
            _db = DBTool.DBInstance;
        }

        protected void Save()
        {
            _db.SaveChanges();
        }


        //Eger bu Add metodunun miras verildigi yerlerde farklı şekilde davranmasını istiyorsak bu metodu virtual olarak işaretleyebiliriz...Tabii ki o miras verilen yerde metodun calısabilmesi _db  field'ına ve Save metoduna ihtiyac duyulacagından dolayı _bu yapılar güvenligi bozmamak adına protected erişim belirteci ile işaretlenmiştir...
        public virtual void Add(T item)
        {
            _db.Set<T>().Add(item);
            Save();
        }

        public void AddRange(List<T> list)
        {
            _db.Set<T>().AddRange(list);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.Status = ENTITIES.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            Save();
        }

        public void DeleteRange(List<T> list)
        {
            foreach (T item in list)
            {
                Delete(item);
            }
        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item);
            Save();
        }

        public void DestroyRange(List<T> list)
        {
            _db.Set<T>().RemoveRange(list);
            Save();
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where( x => x.Status != ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }


        public List<T> GetModifieds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);
        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _db.Set<T>().Select(exp).ToList();
        }

        public void Update(T item)
        {
            item.ModifiedDate = DateTime.Now;
            item.Status = ENTITIES.Enums.DataStatus.Updated;
            T guncellenecek = Find(item.ID);

            //Entry metodu veritabanında bir güncelleme yapılacagını bildirerek giriş(baglantı) yapılmasını saglayan bir metottur...

            _db.Entry(guncellenecek).CurrentValues.SetValues(item);
            //Entry metodu Veritabanına bir modifikasyon girişi var demektir ve bu metodun işlemini hangi veri üzerinden gerceklestirecegini bilmesi gerekir...Bu veriyi ID üzerinden yakalayarak onun güncellenmesi gerektigini söylüyoruz...Onun orijinal degerlerine kendi gönderdigimiz item'in degerlerini atıyoruz...
            Save();

        }

        public void UpdateRange(List<T> list)
        {
            foreach (T item in list)
            {
                Update(item);
            }
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }

        public void SetActive(T item)
        {
            item.DeletedDate = item.ModifiedDate = null;
            item.Status = ENTITIES.Enums.DataStatus.Inserted;
            Save();
           
        }

        public void SetActiveRange(List<T> list)
        {
            foreach (T item in list)
            {
                SetActive(item);
            }
        }

        public List<T> GetDatas(int number)
        {
            return _db.Set<T>().Take(number).ToList();
        }

        public List<T> GetLastDatas(int number)
        {
            return _db.Set<T>().OrderByDescending(x => x.CreatedDate).Take(number).ToList();
        }

        public List<T> GetFirstDatas(int number)
        {
            return _db.Set<T>().OrderBy(x => x.CreatedDate).Take(number).ToList();
        }
    }
}
