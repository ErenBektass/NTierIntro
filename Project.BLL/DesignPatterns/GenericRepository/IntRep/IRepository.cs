using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        //List Commands

        List<T> GetAll(); // bu metot ilgili T neyse o yapıdaki tüm verileri getirecek
        List<T> GetActives(); //bu metot sadece Aktif kullanımda olan verileri getirecek
        List<T> GetPassives(); //bu metot sadece Pasif olan verileri getirecek
        List<T> GetModifieds(); // bu metot sadece güncellenmiş olan verileri getirecek

        //Modify Commands
        void Add(T item);
        void AddRange(List<T> list);
        void Update(T item);
        void UpdateRange(List<T> list);
        void Delete(T item); // bu metot veriyi pasife ceker...
        void DeleteRange(List<T> list);
        void Destroy(T item); //bu metot veriyi yok eder
        void DestroyRange(List<T> list);
        void SetActive(T item);
        void SetActiveRange(List<T> list);

        //Linq Expressions
        List<T> Where(Expression<Func<T,bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T,object>> exp);

        //Find
        T Find(int id);

   

        //Get  last datas
        List<T> GetLastDatas(int number);


       

        //Get first datas
        List<T> GetFirstDatas(int number);

        //Get the counted datas
        List<T> GetDatas(int number);

        


    }
}
