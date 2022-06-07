using Blink.DAL;
using Blink.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blink.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            HomeVeiwModels hvm = new HomeVeiwModels
            {
                news=db.News.ToList()
            };
            return View(hvm);
        }
     
    }
}