using MyTest_eCommerce.Data.Repositorios;
using MyTest_eCommerce.Domain.Servicos;
using MyTest_eCommerce.Model.Interfaces.Repositorios;
using MyTest_eCommerce.Model.Interfaces.Servicos;

namespace MyTest_eCommerce.API.Config {
    public static class IoC {
        public static void ConfigIoC(this IServiceCollection services) {
            services.AddScoped<IServicoDeCadastroDeProduto, ServicoDeCadastroDeProduto>();
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
        }
    }
}
