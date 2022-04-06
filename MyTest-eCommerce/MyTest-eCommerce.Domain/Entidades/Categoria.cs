using MyTest_eCommerce.Model.Entidades;

namespace MyTest_eCommerce.Domain.Entidades {
    public class Categoria : EntidadeBase {
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; private set; }
        public Categoria(int id, string nome) {
            Id = id;
            Nome = nome;
        }
    }
}