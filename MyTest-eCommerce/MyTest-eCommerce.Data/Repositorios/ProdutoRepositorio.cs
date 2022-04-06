using Microsoft.EntityFrameworkCore;
using MyTest_eCommerce.Data.Context;
using MyTest_eCommerce.Data.Repositorios.Shared;
using MyTest_eCommerce.Domain.Entidades;
using MyTest_eCommerce.Model.Interfaces.Repositorios;

namespace MyTest_eCommerce.Data.Repositorios {
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio {

        public ProdutoRepositorio(DataContext dataContext) : base(dataContext) { }

        public override async Task<IEnumerable<Produto>> ObterTodosAsync()
            => await Context.Produtos
                            .Include(p => p.Categoria)
                            .AsNoTracking()
                            .ToListAsync();

        public override async Task<Produto?> ObterPorIdAsync(int id)
            => await Context.Produtos
                            .Include(p => p.Categoria)
                            .FirstOrDefaultAsync(p => p.Id.Equals(id));
    }
}