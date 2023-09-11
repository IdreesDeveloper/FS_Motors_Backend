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
            //optionsBuilder.UseSqlServer("Server=DESKTOP-PAQK102;Database=Fs-Motors;Trusted_Connection=true;TrustServerCertificate=true;");
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PAQK102; Database=Fs-Motors;Integrated Security=True;TrustServerCertificate=true");
            //dotnet ef database update
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModelType> CarModelType { get; set; }
        public DbSet<InvestmentRecord> InvestmentRecords { get; set; }
        public DbSet<Investor> Investors { get; set; } 
        public DbSet<Showroom> Showrooms { get; set; } 
        public DbSet<UserType> UserTypes { get; set; } 
        public DbSet<WorkShop> WorkShops { get; set; } 
    }

}
