using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoyalHospital.Models;
//using RoyalHospital.Models;
using System.Diagnostics;

namespace RoyalHospital.Controllers
{
    public class HomeController : Controller
    {
        private readonly RoyalHospitalContext context;

        public HomeController(RoyalHospitalContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var slideItems = await context.SlideItems.ToListAsync();

            return View(slideItems);
        }
    }
}