using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LekMed.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }

        public IActionResult Index(string filterString)
        {
            if(string.IsNullOrEmpty(filterString))
            {
                return View(TestDatabase.Doctors);
            }

            return View(TestDatabase.Doctors.Where(x => x.Name.ToLower().Contains(filterString.ToLower())).ToList());
        }

        public IActionResult View(int indexOfDoctor)
        {
            return RedirectToAction("Index", "Prescription", new { indexOfDoctor = indexOfDoctor });
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DoctorViewModel doctorVM)
        {
            TestDatabase.Doctors.Add(doctorVM);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int indexOfDoctor)
        {
            return View();
        }
    }
}
