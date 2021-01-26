using System.Collections.Generic;

namespace LekMed
{
    public class DoctorViewModel
    {
        public string Name { get; set; }
        public List<PrescriptionViewModel> Prescriptions { get; set; }
    }
}
