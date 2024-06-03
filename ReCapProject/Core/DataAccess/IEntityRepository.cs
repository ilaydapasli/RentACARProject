using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
//DataAccess klasöründe bütün crud operasyonlarını ve
//databaseler generic olarak yapılandırdığımız kısımdır.

//Burada bir generic yapı bizi karşılıyor.
//Generic yapılara kısaca değinecek olursak;
//tasarlandığımız interface, class, metod ya da
//parametrelerin (argümanların) belirli bir tip için
//değil bir şablon yapısına uyan her tip için çalışmasını
//sağlayan bir yapıdır diyebiliriz.