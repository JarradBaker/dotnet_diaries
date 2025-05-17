using Microsoft.AspNetCore.Mvc;
using DOTNET_DIARIES.Models;
using DOTNET_DIARIES.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogpostsController
{
    public class BlogpostsController : Controller
    {
        private readonly DOTNET_DIARIES_Context _context;
        public BlogpostsController(DOTNET_DIARIES_Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Blogposts.ToListAsync());
        }

    }
}
