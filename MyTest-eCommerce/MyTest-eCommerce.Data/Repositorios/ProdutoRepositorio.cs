using MyTest_eCommerce.Domain.Interfaces;
using MyTest_eCommerce.Domain.Entidades;

namespace MyTest_eCommerce.Data.Repositorios {
    public class ProdutoRepositorio : IProdutoRepositorio {
        async Task<IEnumerable<Produto>> IProdutoRepositorio.ListeTodos() => throw new NotImplementedException("Ainda não cheguei nessa parte");
        async Task<Produto> IProdutoRepositorio.ListePorId(int id) => throw new NotImplementedException("Ainda não cheguei nessa parte");
    }
}