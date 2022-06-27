using Library.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class ProdutoRepository : RepositoryBase<Produtos>, IProdutoRepository
    {
        public ProdutoRepository(bool SaveChanges = true) : base(SaveChanges)
        {

        }
        public ImagensProdutos GetImagemProduto(int prodID)
        {
            return _context.ImagensProdutos.FirstOrDefault(i => i.ProdutoId == prodID);
        }

        public List<ImagensProdutos> GetAllImagens()
        {
            return _context.Set<ImagensProdutos>().ToList();
        }
    }
}
