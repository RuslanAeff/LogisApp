using LogisApp.Data;
using Microsoft.AspNetCore.Mvc;
using LogisApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisApp.Controllers
{
    public class ServiceController : Controller
    {
        readonly ServiceDbContext _context;
        public ServiceController(ServiceDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details (int Id)
        {
            if (Id == 0) return BadRequest(); 
            Service service = _context.Services.FirstOrDefault(s => s.Id == Id);
            if (service == null) return NotFound();
            return View(service);
        }
    }
}
