using Microsoft.EntityFrameworkCore;

namespace Cadastro.Models
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> opcoes) : base(opcoes) { }

        public DbSet<DbUsuario> Usuarios { get; set; }
    }
}
