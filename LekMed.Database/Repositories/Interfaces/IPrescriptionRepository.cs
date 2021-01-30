using System.Collections.Generic;

namespace LekMed.Database
{
    public interface IPrescriptionRepository : IRepository<PrescriptionEntity>
    {
        IEnumerable<PrescriptionEntity> GetAllPrescriptions();
    }
}
