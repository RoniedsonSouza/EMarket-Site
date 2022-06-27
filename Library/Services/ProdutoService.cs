using Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class ProdutoService
    {
        public ProdutoRepository oProdutoRepository { get; set; }
        public ProdutoService()
        {
            oProdutoRepository = new ProdutoRepository();
        }
    }
}
