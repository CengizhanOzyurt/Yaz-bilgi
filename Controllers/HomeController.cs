using Microsoft.AspNetCore.Mvc;
using ProjectForm.Models;
using System.Diagnostics;

namespace ProjectForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly InternDBcontext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, InternDBcontext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index(UsersModel user)
        {


            return View();
        }

        public IActionResult Register()
        {
            var model = new UsersModel();
            return View("~/Views/Register/Register.cshtml",model);
        }

        [HttpPost]
        public IActionResult Register(UsersModel model)
        {
            var context = new InternDBcontext();
            context.Users.Add(model);
            context.SaveChanges();
            return View(model);
        }
        
        
        

        public IActionResult Privacy()
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
