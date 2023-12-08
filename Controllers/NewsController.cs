using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoyalHospital.Models;

namespace RoyalHospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : Controller
    {
        private readonly RoyalHospitalContext context;

        public NewsController(RoyalHospitalContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> GetAllNews()
        {
            var news = await context.News.OrderByDescending(nw => nw.Date).ToListAsync();

            return Ok(news);
        }
    }
}
