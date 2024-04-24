using Microsoft.EntityFrameworkCore;
using STable.API.Model.Domain;

namespace STable.API.Data
{
    public class STableDbContext : DbContext
    {
        public STableDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Result> Results { get; set; }



    }
}
