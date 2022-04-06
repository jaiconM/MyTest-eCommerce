using MyTest_eCommerce.Domain.Entidades;

namespace MyTest_eCommerce.Model.Interfaces.Servicos {
    public interface IServicoDeCadastroDeProduto {
        Task<Produto> ListeProdutoPorId(int id);
        Task<IEnumerable<Produto>> ListeProdutos();
    }
}