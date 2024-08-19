using Microsoft.AspNetCore.Mvc;

namespace app1.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult getAll()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}
