using Microsoft.EntityFrameworkCore;
using MyTest_eCommerce.Data.Context;
using MyTest_eCommerce.Data.Repositorios.Shared;
using MyTest_eCommerce.Domain.Entidades;
using MyTest_eCommerce.Model.Interfaces.Repositorios;

namespace MyTest_eCommerce.Data.Repositorios {
    public class CategoriaRepositorio : RepositorioBase<Categoria>, ICategoriaRepositorio {

        public CategoriaRepositorio(DataContext dataContext) : base(dataContext) { }

    }
}