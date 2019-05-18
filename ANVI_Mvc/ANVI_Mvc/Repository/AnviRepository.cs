using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ANVI_Mvc.Models;

namespace PracMVC01.Repositories
{
    public class AnviRepository<T> where T : class
    {
        private AnviModel _context;

        public AnviRepository(AnviModel context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
            _context = context;
        }
        public void Create(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }
    }
}