using EmprestimoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoApp.DataContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

    }
}
