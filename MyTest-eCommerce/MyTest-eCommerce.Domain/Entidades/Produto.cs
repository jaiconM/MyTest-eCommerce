using MyTest_eCommerce.Model.Entidades;

namespace MyTest_eCommerce.Domain.Entidades {
    public class Produto : EntidadeBase {
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdCategoria { get; private set; }
        public Categoria Categoria { get; set; }

        public Produto(int id, string codigo, int idCategoria, string nome, string descricao, decimal preco) {
            Id = id;
            Codigo = codigo;
            IdCategoria = idCategoria;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            DataCadastro = DateTime.Now;
        }

        public Produto(string codigo, int idCategoria, string nome, string descricao, decimal preco)
            : this(default, codigo, idCategoria, nome, descricao, preco) { }
    }
}