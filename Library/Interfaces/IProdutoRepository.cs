using Library.Models;

namespace Library.Interfaces
{
    public interface IProdutoRepository
    {
        ImagensProdutos GetImagemProduto(int prodID);
    }
}