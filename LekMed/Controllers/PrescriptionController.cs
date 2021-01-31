using LekMed.Core;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LekMed.Controllers
{
    public class PrescriptionController : Controller
    {
        private readonly ViewModelMapper _mapper;
        private readonly IDoctorService _doctorService;

        public PrescriptionController(IDoctorService doctorService, ViewModelMapper mapper) 
        {
            _mapper = mapper;
            _doctorService = doctorService;
        }

        public IActionResult Index(int doctorId, string filterString)
        {
            TempData["doctorId"] = doctorId;

            var prescriptionDtos = _doctorService.GetPrescriptionsForDoctor(doctorId, filterString);
            var doctorDto = _doctorService.GetDoctors(null).FirstOrDefault(x => x.Id == doctorId);

            var prescrptionVMs = _mapper.Map(prescriptionDtos);
            var doctorVM = _mapper.Map(doctorDto);

            doctorVM.Prescriptions = prescrptionVMs;

            return View(doctorVM);
        }

        public IActionResult View(int prescriptionId)
        {
            return RedirectToAction("Index", "Medicine", new { doctorId = int.Parse(TempData["doctorId"].ToString()), prescriptionId = prescriptionId });
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PrescriptionViewModel prescriptionVM)
        {
            int doctorId = int.Parse(TempData["doctorId"].ToString());

            var prescriptionDto = _mapper.Map(prescriptionVM);

            _doctorService.AddNewPrescription(prescriptionDto, doctorId);

            return RedirectToAction("Index", new { doctorId = doctorId });
        }

        public IActionResult Delete(int prescriptionId)
        {
            int doctorId = int.Parse(TempData["doctorId"].ToString());

            _doctorService.DeletePrescription(prescriptionId);

            return RedirectToAction("Index", new { doctorId = doctorId });
        }
    }
}
