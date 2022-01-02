using MyTest_eCommerce.Data.Entidades;

namespace MyTest_eCommerce.Model.Interfaces {
    public interface IServicoDeCadastroDeProduto {
        Produto ListeProdutoPorId(int id);
        IEnumerable<Produto> ListeProdutos();
    }
}