

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoresG1.API.Data;
using StoresG1.Shared.Entities;

namespace StoresG1.API.Controllers
{

    [ApiController]
    [Route("/api/countries")]
    public class CountriesController:ControllerBase
    {
        private readonly DataContext _context;
    
        public CountriesController(DataContext context)
        {


            _context = context; 
        }


        [HttpPost]
        public async Task<ActionResult>Post(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok();

        }



        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Countries.ToListAsync());

        }

    }
}
