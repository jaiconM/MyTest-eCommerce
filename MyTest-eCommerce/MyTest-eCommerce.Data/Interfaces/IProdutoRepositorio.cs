using MyTest_eCommerce.Data.Entidades;

namespace MyTest_eCommerce.Data.Interfaces {
    public interface IProdutoRepositorio {
        IEnumerable<Produto> ListeTodos();
        Produto ListePorId(int id);
    }
}