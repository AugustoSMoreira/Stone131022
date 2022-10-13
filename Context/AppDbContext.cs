using Microsoft.EntityFrameworkCore;
using Stone131022.Models;

namespace Stone131022.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Jogador> GetJogadores { get; set; }
        public DbSet<Medalha> GetMedalhas { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                    "Server=localhost;initial catalog=CRUD_MYSQL;uid=root;pwd=admin;",
                        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql"));
        }*/
    }
}
