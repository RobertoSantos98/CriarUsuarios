using CriarUsuarios.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CriarUsuarios.Infrastructure
{
    public class ConnectionContext : DbContext
    {

        public DbSet<User> User { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;Database=usuarios;" +
                "User Id=postgres;" +
                "Password=admin;"
            );

    }
}
