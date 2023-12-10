using Microsoft.AspNetCore.Mvc;
using LogisApp.Models;
using LogisApp.Data;

namespace LogisApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ServiceDbContext _context;
        public HomeController(ServiceDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List <Service> model = _context.Services.ToList();
            return View(model);
        }
    }
}
