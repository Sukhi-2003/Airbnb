using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Airbnb.Data;
using Airbnb.Models;
using Airbnb.Services;

namespace Airbnb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;
        public LocationsController(ILocationService locationService)
        { 
            _locationService = locationService;
        }

        // GET: api/Locations
        [HttpGet]
        public  ActionResult<IEnumerable<Location>> GetAll()
        {
            return  Ok(_locationService.GetAll());
        }

        // GET: api/Locations/5
        [HttpGet("{id}")]
        public  ActionResult<Location> GetLocation(int id)
        {
            return _locationService.GetLocation(id);
        }

        //// PUT: api/Locations/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutLocation(int id, Location location)
        //{
        //    if (id != location.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(location).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LocationExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Locations
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Location>> PostLocation(Location location)
        //{
        //    _context.Locations.Add(location);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetLocation", new { id = location.Id }, location);
        //}

        //// DELETE: api/Locations/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteLocation(int id)
        //{
        //    var location = await _context.Locations.FindAsync(id);
        //    if (location == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Locations.Remove(location);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool LocationExists(int id)
        //{
        //    return _context.Locations.Any(e => e.Id == id);
        //}
    }
}
