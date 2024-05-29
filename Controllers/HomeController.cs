using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FileUploads.Controllers
{
    public class HomeController : Controller
    {  
        public IActionResult Index()
        {
            return View();
        }
    }
}
