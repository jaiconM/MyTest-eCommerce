using Microsoft.AspNetCore.Mvc;
using MyTest_eCommerce.Data.Entidades;
using MyTest_eCommerce.Model.Interfaces;

namespace MyTest_eCommerce.API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase {

        private readonly ILogger<ProdutosController> _logger;
        private readonly IServicoDeCadastroDeProduto _servicoDeCadastroDeProduto;

        public ProdutosController(ILogger<ProdutosController> logger, IServicoDeCadastroDeProduto servicoDeCadastroDeProduto) {
            _logger = logger;
            _servicoDeCadastroDeProduto = servicoDeCadastroDeProduto;
        }

        [HttpGet]
        public IEnumerable<Produto> ListeTodos() {
            try {
                return _servicoDeCadastroDeProduto.ListeProdutos();
            }
            catch (Exception erro) {
                _logger.LogError(erro, "ProdutosController.ListeTodos");
                throw;
            }
        }
    }
}