using System.Collections.Generic;

namespace LekMed.Database
{
    public interface IMedicineRepository : IRepository<MedicineEntity>
    {
        IEnumerable<MedicineEntity> GetAllMedicines();
    }
}
