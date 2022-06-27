using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class EmpresaRepository : RepositoryBase<Empresa>
    {
        public EmpresaRepository(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
