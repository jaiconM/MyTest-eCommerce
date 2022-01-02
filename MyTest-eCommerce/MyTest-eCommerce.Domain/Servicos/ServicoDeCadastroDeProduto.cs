using MyTest_eCommerce.Data.Entidades;
using MyTest_eCommerce.Data.Interfaces;
using MyTest_eCommerce.Model.Interfaces;

namespace MyTest_eCommerce.Model.Servicos {
    public class ServicoDeCadastroDeProduto : IServicoDeCadastroDeProduto {
        private readonly IProdutoRepositorio _repositorioDeProduto;

        public ServicoDeCadastroDeProduto(IProdutoRepositorio repositorioDeProduto)
            => _repositorioDeProduto = repositorioDeProduto;

        public IEnumerable<Produto> ListeProdutos() => _repositorioDeProduto.ListeTodos();
        public Produto ListeProdutoPorId(int id) => _repositorioDeProduto.ListePorId(id);
    }
}
