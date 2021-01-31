using System;
using System.Collections.Generic;
using System.Text;

namespace LekMed.Core
{
    public interface IDoctorService
    {
        bool AddNewDoctor(DoctorDto doctor);
        bool AddNewMedicine(MedicineDto medicine, int prescriptionId);
        bool AddNewPrescription(PrescriptionDto prescription, int doctorId);
        bool DeleteDoctor(int doctorId);
        bool DeleteMedicine(int medicineId);
        bool DeletePrescription(int prescriptionId);
        IEnumerable<DoctorDto> GetDoctors(string filterString);
        IEnumerable<MedicineDto> GetMedicinesForPrescription(int prescriptionId, string filterString);
        IEnumerable<PrescriptionDto> GetPrescriptionsForDoctor(int doctorId, string filterString);
    }
}
