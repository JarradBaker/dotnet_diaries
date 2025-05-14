using Microsoft.AspNetCore.Mvc;
using DOTNET_DIARIES.Models;
using DOTNET_DIARIES.Data;

namespace BlogpostsController
{
    public class BlogpostsController : Controller
    {
        // GET: DOTNET_DIARIES
        /*blic ActionResult Index()
        {
            return View();
        }*/

        public IActionResult Random()
        {
           return Content("Hello from Blogpost");
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
