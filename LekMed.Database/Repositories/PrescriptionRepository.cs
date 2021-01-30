using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LekMed.Database
{
    public class PrescriptionRepository: BaseRepository<PrescriptionEntity>, IPrescriptionRepository
    {
        protected override DbSet<PrescriptionEntity> _dbSet => _dbContext.Prescriptions;

        public PrescriptionRepository(LekMedDbContext context) : base(context) { }

        public IEnumerable<PrescriptionEntity> GetAllPrescriptions()
        {
            return _dbSet.Select(x => x).Include(m => m.Medicines);
        }
    }
}
