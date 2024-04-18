using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Service_for_Work.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Models.Model.Product> Products { get; set; }
        public DbSet<Models.Model.User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataForAPIAristokratia.db");
        }
    }
}
