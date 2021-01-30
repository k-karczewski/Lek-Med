using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LekMed.Database
{
    public class DoctorRepository : BaseRepository<DoctorEntity>, IDoctorRepository
    {
        protected override DbSet<DoctorEntity> _dbSet => _dbContext.Doctors;

        public DoctorRepository(LekMedDbContext context): base(context) { }

        public IEnumerable<DoctorEntity> GetAllDoctors()
        {
            return _dbSet.Select(x => x).Include(p => p.Prescriptions).ThenInclude(m => m.Medicines);
        }
    }
}
