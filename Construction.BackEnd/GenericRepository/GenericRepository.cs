using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Construction.BackEnd.Data;

namespace Construction.BackEnd.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public bool CheckIfExists()
        {
             if(_context.Set<T>().Any()) return true;
            else return false;
        }

        public int Count()
        {
            return _context.Set<T>().Count();
        }

        public void Create(T t)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
        }

        public List<T> GetBy(Expression<Func<T, bool>> predicate)
        {
           return _context.Set<T>().Where(predicate).ToList();
          
        }

        public T GetFirst()
        {
            return _context.Set<T>().FirstOrDefault();
        }

        public List<T> GetList()
        {
           return _context.Set<T>().ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public void Remove(T t)
        {
            _context.Set<T>().Remove(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Set<T>().Update(t);
            _context.SaveChanges();
           
        }
    }
}