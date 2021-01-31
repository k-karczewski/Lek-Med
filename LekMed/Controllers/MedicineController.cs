using LekMed.Core;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LekMed
{
    public class MedicineController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly ViewModelMapper _mapper;

        public MedicineController(IDoctorService doctorService, ViewModelMapper mapper) 
        {
            _mapper = mapper;
            _doctorService = doctorService;
        }

        public IActionResult Index(int doctorId, int prescriptionId, string filterString)
        {
            TempData["doctorId"] = doctorId;
            TempData["prescriptionId"] = prescriptionId;

            var medicineDtos = _doctorService.GetMedicinesForPrescription(prescriptionId, filterString);
            var prescriptionDto = _doctorService.GetPrescriptionsForDoctor(doctorId, null).FirstOrDefault(x => x.Id == prescriptionId);

            prescriptionDto.Doctor = new DoctorDto
            {
                Id = doctorId
            };

            var medicineVMs = _mapper.Map(medicineDtos);
            var prescriptionVM = _mapper.Map(prescriptionDto);

            prescriptionVM.Medicines = medicineVMs;

            return View(prescriptionVM);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(MedicineViewModel medicinenVM)
        {
            int doctorId = int.Parse(TempData["doctorId"].ToString());
            int prescriptionId = int.Parse(TempData["prescriptionId"].ToString());

            var medicineDto = _mapper.Map(medicinenVM);

            _doctorService.AddNewMedicine(medicineDto, prescriptionId);

            return RedirectToAction("Index", new { doctorId = doctorId, prescriptionId = prescriptionId });
        }

        public IActionResult Delete(int medicineId)
        {
            int doctorId = int.Parse(TempData["doctorId"].ToString());
            int prescriptionId = int.Parse(TempData["prescriptionId"].ToString());

            _doctorService.DeleteMedicine(medicineId);

            return RedirectToAction("Index", new { doctorId = doctorId, prescriptionId = prescriptionId });
        }
    }
}
