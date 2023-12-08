using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoyalHospital.Models;

namespace RoyalHospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : Controller
    {
        private readonly RoyalHospitalContext context;

        public DoctorsController(RoyalHospitalContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDoctors()
        {
            var doctors = await context.Doctors.ToListAsync();

            return Ok(doctors);
        }
    }
}
