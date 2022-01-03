using MyTest_eCommerce.Domain.Entidades;
using MyTest_eCommerce.Domain.Interfaces;

namespace MyTest_eCommerce.Domain.Servicos {
    public class ServicoDeCadastroDeProduto : IServicoDeCadastroDeProduto {
        private readonly IProdutoRepositorio _repositorioDeProduto;

        public ServicoDeCadastroDeProduto(IProdutoRepositorio repositorioDeProduto)
            => _repositorioDeProduto = repositorioDeProduto;

        public async Task<IEnumerable<Produto>> ListeProdutos() => await _repositorioDeProduto.ListeTodos();
        public async Task<Produto> ListeProdutoPorId(int id) => await _repositorioDeProduto.ListePorId(id);
    }
}
