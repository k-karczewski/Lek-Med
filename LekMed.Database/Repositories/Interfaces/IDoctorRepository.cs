using System.Collections.Generic;

namespace LekMed.Database
{
    public interface IDoctorRepository : IRepository<DoctorEntity>
    {
        IEnumerable<DoctorEntity> GetAllDoctors();
    }
}
