using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoyalHospital.Models;

namespace RoyalHospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicsController : Controller
    {
        private readonly RoyalHospitalContext context;

        public ClinicsController(RoyalHospitalContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClinics()
        {
            var clinics = await context.Clinics.ToListAsync();

            return Ok(clinics);
        }
    }
}
