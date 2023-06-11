using Microsoft.EntityFrameworkCore;

namespace TacettinProje.Models {
    public class AppDbContext : DbContext {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=GelenSiparisler;Uid=root;Pwd=");
        }

        public DbSet<gelenSiparis> siparisler { get; set; }
    }
}