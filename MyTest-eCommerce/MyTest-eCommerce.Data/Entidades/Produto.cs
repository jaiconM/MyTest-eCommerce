﻿using MyTest_eCommerce.Data.Enums;

namespace MyTest_eCommerce.Data.Entidades {
    public class Produto {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Categoria Categoria { get; set; }
    }
}