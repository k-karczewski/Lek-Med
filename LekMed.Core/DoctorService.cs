using AutoMapper;
using LekMed.Database;
using System.Collections.Generic;
using System.Linq;

namespace LekMed.Core
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IPrescriptionRepository _prescriptionRepository;
        private readonly IMedicineRepository _medicineRepository;
        private readonly DoctorsMapper _mapper;

        public DoctorService(IDoctorRepository doctorRepository, IPrescriptionRepository prescriptionRepository, IMedicineRepository medicineRepository, DoctorsMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _prescriptionRepository = prescriptionRepository;
            _medicineRepository = medicineRepository;
            _mapper = mapper;
        }

        public IEnumerable<DoctorDto> GetDoctors(string filterString)
        {
            var doctorEntities = _doctorRepository.GetAllDoctors();

            if (!string.IsNullOrEmpty(filterString))
            {
                doctorEntities = doctorEntities.Where(x => x.FirstName.ToLower().Contains(filterString.ToLower()) || x.LastName.ToLower().Contains(filterString.ToLower()));
            }

            return _mapper.Map(doctorEntities);
        }

        public IEnumerable<PrescriptionDto> GetPrescriptionsForDoctor(int doctorId, string filterString)
        {
            var prescriptionEntities = _prescriptionRepository.GetAllPrescriptions().Where(x => x.DoctorId == doctorId);

            if (!string.IsNullOrEmpty(filterString))
            {
                prescriptionEntities = prescriptionEntities.Where(x => x.Name.ToLower().Contains(filterString.ToLower()));
            }

            return _mapper.Map(prescriptionEntities);
        }

        public IEnumerable<MedicineDto> GetMedicinesForPrescription(int prescriptionId, string filterString)
        {
            var medicineEntities = _medicineRepository.GetAllMedicines().Where(x => x.PrescriptionId == prescriptionId);

            if (!string.IsNullOrEmpty(filterString))
            {
                medicineEntities = medicineEntities.Where(x => x.Name.ToLower().Contains(filterString.ToLower()) ||
                                                               x.ActiveSubstance.ToLower().Contains(filterString.ToLower()) ||
                                                               x.CompanyName.ToLower().Contains(filterString.ToLower()));
            }

            return _mapper.Map(medicineEntities);
        }

        public bool AddNewMedicine(MedicineDto medicine, int prescriptionId)
        {
            var medicineEntity = _mapper.Map(medicine);

            medicineEntity.PrescriptionId = prescriptionId;

            return _medicineRepository.AddNew(medicineEntity);
        }

        public bool AddNewPrescription(PrescriptionDto prescription, int doctorId)
        {
            var prescriptionEntity = _mapper.Map(prescription);

            prescriptionEntity.DoctorId = doctorId;

            return _prescriptionRepository.AddNew(prescriptionEntity);
        }

        public bool AddNewDoctor(DoctorDto doctor)
        {
            var doctorEntity = _mapper.Map(doctor);

            return _doctorRepository.AddNew(doctorEntity);
        }

        public bool DeleteMedicine(int medicineId)
        {
            return _medicineRepository.Delete(medicineId);
        }

        public bool DeletePrescription(int prescriptionId)
        {
            return _prescriptionRepository.Delete(prescriptionId);
        }

        public bool DeleteDoctor(int doctorId)
        {
            return _doctorRepository.Delete(doctorId);
        }
    }
}
