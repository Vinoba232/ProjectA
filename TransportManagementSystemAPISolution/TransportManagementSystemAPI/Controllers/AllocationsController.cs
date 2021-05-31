using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransportManagementSystemAPI.Models;

namespace TransportManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllocationsController : ControllerBase
    {
        private readonly TransportContext _context;

        public AllocationsController(TransportContext context)
        {
            _context = context;
        }

        // GET: api/Allocations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Allocation>>> GetAllocations()
        {
            return await _context.Allocations.ToListAsync();
        }

        //GET: api/Allocations/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Allocation>> GetAllocation(int id)
        //{
        //    var allocation = await _context.Allocations.FindAsync(id);

        //    if (allocation == null)
        //    {
        //        return NotFound();
        //    }

        //    return allocation;
        //}

        // PUT: api/Allocations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAllocation(int id, Allocation allocation)
        {
            if (id != allocation.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(allocation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllocationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Allocations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Allocation>> PostAllocation(Allocation allocation)
        {
            _context.Allocations.Add(allocation);          
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AllocationExists(allocation.EmployeeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAllocation", new { id = allocation.EmployeeId }, allocation);
        }
        [HttpGet("{location}")]
        public async Task<ActionResult<List<Route>>> FindRoutes(string location)
        {
            var route = await _context.Routes.Where(x => x.Stop1 == location || x.Stop2 == location
            || x.Stop3 == location).ToListAsync();
            
            if (route == null)
            {
                return NotFound();
            }
            return route;
        }


        // DELETE: api/Allocations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAllocation(int id)
        {
            var allocation = await _context.Allocations.FindAsync(id);
            if (allocation == null)
            {
                return NotFound();
            }

            _context.Allocations.Remove(allocation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AllocationExists(int id)
        {
            return _context.Allocations.Any(e => e.EmployeeId == id);
        }
    }
}
