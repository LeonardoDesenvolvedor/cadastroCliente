using Cadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes  { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
