using System.Collections.Generic;

namespace LekMed.Core
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int WorkYears { get; set; }
        public bool IsAbleToMakePrescription { get; set; }

        public List<PrescriptionDto> Prescriptions { get; set; }
    }
}
