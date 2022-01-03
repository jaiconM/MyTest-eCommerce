using Microsoft.AspNetCore.Mvc;
using MyTest_eCommerce.Domain.Entidades;
using MyTest_eCommerce.Domain.Interfaces;

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
        public async Task<ActionResult<IEnumerable<Produto>>> ListeTodos() {
            try {
                var produtos = await _servicoDeCadastroDeProduto.ListeProdutos();
                return produtos.ToList();
            }
            catch (Exception erro) {
                _logger.LogError(erro, "ProdutosController.ListeTodos");
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> ListeProdutoPorId(int id) {
            try {
                return await _servicoDeCadastroDeProduto.ListeProdutoPorId(id);
            }
            catch (Exception erro) {
                _logger.LogError(erro, "ProdutosController.ListeProdutoPorId");
                throw;
            }
        }
    }
}