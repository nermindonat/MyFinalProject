using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Core katmanı diğer katmanları referans almaz.
    //generic constraint----generic kısıt
    //class:referans tip demek
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new 'lenebilir olmalı
    //IEntity new'lenemez
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //bu yapı bizim ürünleri her türlü filtrelememizi sağlar.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
