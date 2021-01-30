using System;
using System.Collections.Generic;
using System.Text;

namespace LekMed.Database
{
    public class MedicineEntity : BaseEntity
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string ActiveSubstance { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public DateTime ExpirationDate { get; set; }

        public int PrescriptionId { get; set; }
        public virtual PrescriptionEntity Prescription { get; set; }
    }
}
