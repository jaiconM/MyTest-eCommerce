using MyTest_eCommerce.Model.Entidades;

namespace MyTest_eCommerce.Model.Interfaces.Repositorios {
    public interface IRepositorioBase<TEntidade> : IDisposable where TEntidade : EntidadeBase {
        Task<IEnumerable<TEntidade>> ObterTodosAsync();
        Task<TEntidade?> ObterPorIdAsync(int id);
        Task<object> AdicionarAsync(TEntidade objeto);
        Task AtualizarAsync(TEntidade objeto);
        Task RemoverAsync(TEntidade objeto);
        Task RemoverPorIdAsync(int id);
    }
}
