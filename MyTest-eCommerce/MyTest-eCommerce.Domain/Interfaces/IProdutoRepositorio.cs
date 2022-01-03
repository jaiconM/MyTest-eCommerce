using MyTest_eCommerce.Domain.Entidades;

namespace MyTest_eCommerce.Domain.Interfaces {
    public interface IProdutoRepositorio {
        Task<IEnumerable<Produto>> ListeTodos();
        Task<Produto> ListePorId(int id);
    }
}