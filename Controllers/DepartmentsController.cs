using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoyalHospital.Models;

namespace RoyalHospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : Controller
    {
        private readonly RoyalHospitalContext context;

        public DepartmentsController(RoyalHospitalContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            var departments = await context.Departments.ToListAsync();

            return Ok(departments);
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartment(string selector)
        {
            //var department = await context.Departments.Where(dp => dp.Selector)
            //                       .FirstOrDefaultAsync();
            return NotFound();
        }
    }
}
