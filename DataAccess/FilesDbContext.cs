using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class FilesDbContext : DbContext
    {
        public DbSet<File> Files { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=localhost;Database=AdventureWorksDW2019;Trusted_Connection=True;");
        }
    }
}
