using Library.Interfaces;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected ApplicationDbContext _context;
        public bool _SaveChanges = true;

        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _context = new ApplicationDbContext();
        }

        public T Add(T objeto)
        {
            _context.Set<T>().Add(objeto);

            if (_SaveChanges)
            {
                _context.SaveChanges();
            }
            return objeto;
        }

        public void DeleteById(int id)
        {
            var obj = GetById(id);
            Delete(obj);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<T> SelecionarTodos()
        {
            return _context.Set<T>().ToList();
        }

        public T Update(T objeto)
        {
            _context.Entry(objeto).State = EntityState.Modified;

            if (_SaveChanges)
            {
                _context.SaveChanges();
            }
            return objeto;
        }

        public void Delete(T objeto)
        {
            _context.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                _context.SaveChanges();
            }
        }
    }
}
