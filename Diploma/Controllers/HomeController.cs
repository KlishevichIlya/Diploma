using Diploma.Data;
using Diploma.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Diploma.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {            
            return View(await _context.News.Where(x => x.OnMainPage == true).ToListAsync());
        }

        public IActionResult Documents()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public async Task<IActionResult> News()
        {
            return View(await _context.News.ToListAsync());
        }

        public IActionResult Faculty()
        {
            return View();
        }
        
        public async Task<IActionResult> Specialities(int id)
        {
            return View(await _context.Subject.FirstOrDefaultAsync(x => x.Id == id));
        }

        public IActionResult Info()
        {
            return View();
        }

        public IActionResult Retake()
        {
            return View();
        }

        public IActionResult Plans()
        {
            return View();
        }

        public IActionResult Staff()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
