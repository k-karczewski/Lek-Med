using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LekMed.Controllers
{
    public class PrescriptionController : Controller
    {
        private int IndexOfDoctor { get; set; }

        public PrescriptionController() { }

        public IActionResult Index(int indexOfDoctor, string filterString)
        {
            IndexOfDoctor = indexOfDoctor;

            if (string.IsNullOrEmpty(filterString))
            {
                return View(TestDatabase.Doctors.ElementAt(indexOfDoctor));
            }
            
            return View(new DoctorViewModel 
                    { 
                        Name = TestDatabase.Doctors.ElementAt(indexOfDoctor).Name,
                        Prescriptions = TestDatabase.Doctors.ElementAt(indexOfDoctor).Prescriptions.Where(x => x.Name.ToLower().Contains(filterString.ToLower())).ToList()
                    });
        }

        public IActionResult View(int indexOfDoctor, int indexOfPrescription)
        {
            return RedirectToAction("Index", "Medicine", new { indexOfDoctor = indexOfDoctor, indexOfPrescription = indexOfPrescription });
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PrescriptionViewModel prescriptionVM)
        {
            TestDatabase.Doctors.ElementAt(IndexOfDoctor).Prescriptions.Add(prescriptionVM);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int indexOfPrescription)
        {
            return View();
        }
    }
}
