using MyTest_eCommerce.Domain.Entidades;

namespace MyTest_eCommerce.Domain.Interfaces {
    public interface IServicoDeCadastroDeProduto {
        Task<Produto> ListeProdutoPorId(int id);
        Task<IEnumerable<Produto>> ListeProdutos();
    }
}