using System;
using System.Collections.Generic;
using System.Text;

namespace LekMed.Database
{
    public class PrescriptionEntity : BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public int DoctorId { get; set; }
        public virtual DoctorEntity Doctor { get; set; }

        public virtual IEnumerable<MedicineEntity> Medicines { get; set; }
    }
}
