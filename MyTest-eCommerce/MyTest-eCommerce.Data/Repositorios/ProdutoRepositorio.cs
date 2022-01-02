using MyTest_eCommerce.Data.Entidades;

namespace MyTest_eCommerce.Data.Interfaces {
    public class ProdutoRepositorio : IProdutoRepositorio {
        IEnumerable<Produto> IProdutoRepositorio.ListeTodos() => throw new NotImplementedException("Ainda não cheguei nessa parte");
        Produto IProdutoRepositorio.ListePorId(int id) => throw new NotImplementedException("Ainda não cheguei nessa parte");
    }
}