using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key); //generic olmayan versiyonu
        void Add(string key, object value, int duration);     //cache te ne kadar kalacak.
        bool IsAdd(string key);   //Cachete var mı?
        void Remove(string key);   //Cacheten uçurma.
        void RemoveByPattern(string pattern);     //isimden 
    }
}
