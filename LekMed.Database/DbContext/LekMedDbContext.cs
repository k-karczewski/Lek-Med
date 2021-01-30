using Microsoft.EntityFrameworkCore;

namespace LekMed.Database
{
    public class LekMedDbContext : DbContext
    {
        public LekMedDbContext(DbContextOptions options): base(options) { }
    }
}
