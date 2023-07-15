global using Microsoft.EntityFrameworkCore;
using FS_Motors.Models;

namespace FS_Motors.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Fs-Motors;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<User> Users { get; set; } 
    }
}
