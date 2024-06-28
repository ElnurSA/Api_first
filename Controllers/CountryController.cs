using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_First.Data;
using API_First.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_First.Controllers
{
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CountryController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int? id)
        {
            var existData = await _context.Countries.FindAsync(id);

            if (existData is null) return NotFound();

            return Ok(existData);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Country country)
        {
            if (!ModelState.IsValid) return BadRequest();

            await _context.Countries.AddAsync(country);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Create), country);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, string country)
        {
            if (!ModelState.IsValid) return BadRequest();

            var existData = await _context.Countries.FindAsync(id);

            if (existData is null) return NotFound();


            existData.Name = country;

            await _context.SaveChangesAsync();

            return Ok(existData);

        }

        // DELETE api/values/5
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null) return BadRequest();

            var existData = _context.Countries.Find(id);

            if (existData is null) return NotFound();

            _context.Remove(existData);

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}

