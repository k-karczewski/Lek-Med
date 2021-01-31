using System;
using System.Collections.Generic;
using System.Text;

namespace LekMed.Database
{
    public class DoctorEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int WorkYears { get; set; }
        public bool IsAbleToMakePrescription { get; set; }

        public virtual IEnumerable<PrescriptionEntity> Prescriptions { get; set; }
    }
}
