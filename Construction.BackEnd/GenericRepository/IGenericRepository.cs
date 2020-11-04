using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Construction.BackEnd.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        void Create(T t);
        List<T> GetList();
        void Remove(T t);
        void Update(T t );
        T GetSingle(Expression<Func<T,bool>> predicate);
        T GetFirst();
        List<T> GetBy(Expression<Func<T, bool>> predicate); 
        int Count();
        bool CheckIfExists();
        
         
    }
}