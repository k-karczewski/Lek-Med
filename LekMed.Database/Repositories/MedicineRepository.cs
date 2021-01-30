using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LekMed.Database
{
    public class MedicineRepository : BaseRepository<MedicineEntity>, IMedicineRepository
    {
        protected override DbSet<MedicineEntity> _dbSet => _dbContext.Medicines;

        public MedicineRepository(LekMedDbContext context) : base(context) { }

        public IEnumerable<MedicineEntity> GetAllMedicines()
        {
            return _dbSet.Select(x => x);
        }
    }
}
