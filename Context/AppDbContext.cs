using Microsoft.EntityFrameworkCore;
using Stone131022.Models;

namespace Stone131022.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Jogador> GetJogadores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                    "Server=localhost;initial catalog=CRUD_MYSQL;uid=root;pwd=admin",
                        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql"));
        }
    }
}
