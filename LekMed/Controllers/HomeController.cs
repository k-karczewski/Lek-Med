using LekMed.Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LekMed.Controllers
{
    public class HomeController : Controller
    {
        private readonly ViewModelMapper _mapper;
        private readonly IDoctorService _doctorService;

        public HomeController(IDoctorService doctorService, ViewModelMapper mapper) 
        {
            _doctorService = doctorService;
            _mapper = mapper;
        }

        public IActionResult Index(string filterString)
        {
            var doctorVMs = _mapper.Map(_doctorService.GetDoctors(filterString));

            return View(doctorVMs);
        }

        public IActionResult View(int doctorId)
        {
            return RedirectToAction("Index", "Prescription", new { doctorId = doctorId });
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DoctorViewModel doctorVM)
        {
            _doctorService.AddNewDoctor(_mapper.Map(doctorVM));
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int doctorId)
        {
            _doctorService.DeleteDoctor(doctorId);

            return RedirectToAction("Index");
        }
    }
}
