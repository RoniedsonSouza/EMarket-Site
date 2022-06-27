using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IRepositoryModel<T> where T : class
    {
        List<T> SelecionarTodos();
        T GetById(int id);
        T Add(T objeto);
        T Update(T objeto);
        void Delete(T objeto);
        void DeleteById(int id);
        void SaveChanges();
    }
}
