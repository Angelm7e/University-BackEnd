using Microsoft.EntityFrameworkCore;
using universityBackEnd.Models.DataModels;
namespace universityBackEnd.Data
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options):base(options) 
        {

        }
        // TODO: Add DbSets
        public DbSet <User> User { get; set; }
    }
}
