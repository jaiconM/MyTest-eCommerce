using MyTest_eCommerce.Data.Entidades;
using MyTest_eCommerce.Data.Interfaces;
using MyTest_eCommerce.Model.Interfaces;

namespace MyTest_eCommerce.Model.Servicos {
    public class ServicoDeCadastroDeProduto : IServicoDeCadastroDeProduto {
        private readonly IProdutoRepositorio _repositorioDeProduto;

        public ServicoDeCadastroDeProduto(IProdutoRepositorio repositorioDeProduto)
            => _repositorioDeProduto = repositorioDeProduto;

        public async Task<IEnumerable<Produto>> ListeProdutos() => await _repositorioDeProduto.ListeTodos();
        public async Task<Produto> ListeProdutoPorId(int id) => await _repositorioDeProduto.ListePorId(id);
    }
}
