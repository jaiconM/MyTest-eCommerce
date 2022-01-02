using MyTest_eCommerce.Data.Entidades;

namespace MyTest_eCommerce.Data.Interfaces {
    public interface IProdutoRepositorio {
        Task<IEnumerable<Produto>> ListeTodos();
        Task<Produto> ListePorId(int id);
    }
}