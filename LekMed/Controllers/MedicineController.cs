using Microsoft.AspNetCore.Mvc;

namespace LekMed.Controllers
{
    public class MedicineController : Controller
    {
        public MedicineController() {}

        public IActionResult Index()
        {
            return View();
        }
    }
}
