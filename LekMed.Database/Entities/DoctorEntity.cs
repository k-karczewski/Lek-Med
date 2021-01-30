using System;
using System.Collections.Generic;
using System.Text;

namespace LekMed.Database
{
    public class DoctorEntity : BaseEntity
    {
        public int FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int WorkYears { get; set; }
        public bool IsAbleToMakePrescription { get; set; }

        public virtual List<PrescriptionEntity> Prescriptions { get; set; }
    }
}
