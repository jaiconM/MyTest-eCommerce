using Microsoft.EntityFrameworkCore;
using MyTest_eCommerce.Data.Context;
using MyTest_eCommerce.Model.Entidades;
using MyTest_eCommerce.Model.Interfaces.Repositorios;

namespace MyTest_eCommerce.Data.Repositorios.Shared {
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : EntidadeBase {
        protected readonly DataContext Context;

        public RepositorioBase(DataContext dataContext)
            => Context = dataContext;

        public virtual async Task<object> AdicionarAsync(TEntidade objeto) {
            Context.Add(objeto);
            await Context.SaveChangesAsync();
            return objeto.Id;
        }

        public virtual async Task AtualizarAsync(TEntidade objeto) {
            Context.Entry(objeto).State = EntityState.Modified;
            await Context.SaveChangesAsync();
        }

        public virtual async void Dispose()
            => Context.Dispose();

        public virtual async Task<TEntidade?> ObterPorIdAsync(int id)
            => await Context.Set<TEntidade>()
                            .FindAsync(id);

        public virtual async Task<IEnumerable<TEntidade>> ObterTodosAsync()
            => await Context.Set<TEntidade>()
                            .AsNoTracking()
                            .ToListAsync();

        public virtual async Task RemoverAsync(TEntidade objeto) {
            Context.Set<TEntidade>().Remove(objeto);
            await Context.SaveChangesAsync();
        }

        public virtual async Task RemoverPorIdAsync(int id) {
            var objeto = await ObterPorIdAsync(id);
            if (objeto == null) {
                throw new Exception("O registro não existe na base de dados.");
            }
            await RemoverAsync(objeto);
        }
    }
}
