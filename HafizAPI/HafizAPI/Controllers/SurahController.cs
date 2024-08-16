using Microsoft.AspNetCore.Mvc;

namespace HafizApi.Controllers
{
    public class SurahController : Controller
    {
        public IActionResult Read()
        {
            return View();
        }
    }
}
