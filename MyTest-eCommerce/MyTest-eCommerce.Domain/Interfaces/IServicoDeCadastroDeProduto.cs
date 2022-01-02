using MyTest_eCommerce.Data.Entidades;

namespace MyTest_eCommerce.Model.Interfaces {
    public interface IServicoDeCadastroDeProduto {
        Task<Produto> ListeProdutoPorId(int id);
        Task<IEnumerable<Produto>> ListeProdutos();
    }
}