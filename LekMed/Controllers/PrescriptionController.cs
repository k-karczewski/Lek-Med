using Microsoft.AspNetCore.Mvc;

namespace LekMed.Controllers
{
    public class PrescriptionController : Controller
    {
        public PrescriptionController() { }

        public IActionResult Index()
        {
            return View();
        }
    }
}
