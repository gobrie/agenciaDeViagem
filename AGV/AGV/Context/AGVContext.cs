using AGV.Models;
using Microsoft.EntityFrameworkCore;

namespace AGV.Context
{
    public class AGVContext :DbContext
    {
        public AGVContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }

}
