using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModels
{
    public class ViewModel

    {
        public ViewModel(Empresa empresa, List<Produtos> produto, List<ImagensProdutos> imagens)
        {
            Empresa = empresa;
            Produtos = produto;
            ImagensProdutos = imagens;
        }

        public Empresa Empresa { get; private set; }
        public List<Produtos> Produtos { get; private set; }
        public List<ImagensProdutos> ImagensProdutos { get; private set; }
    }
}
