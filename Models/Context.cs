using Microsoft.EntityFrameworkCore;

namespace Tatitours3.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 

        {



        }



        public DbSet<Cliente> Clientes { get; set; }



        public DbSet<Cidade> Cidades { get; set; }



        public DbSet<Pacote> Pacotes { get; set; }



        public DbSet<Contato> Contatos { get; set; }
}
}
