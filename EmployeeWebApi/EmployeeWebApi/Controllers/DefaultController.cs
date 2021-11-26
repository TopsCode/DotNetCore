using EDMCrud.Models;
using EmployeeWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly CompanyContext _context;
        public DefaultController(CompanyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<tblemployee>>> GetEmployees()
        {
            return await _context.tblemployees.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<tblemployee>> GetEmployeeByID(int id)
        {
            var employee = await _context.tblemployees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        [HttpPost]
        public async Task<ActionResult<tblemployee>> AddEmployee(tblemployee obj)
        {
            _context.tblemployees.Add(obj);
            await _context.SaveChangesAsync();

            // returns the inserted record.
            return CreatedAtAction("GetEmployeeByID", new { id = obj.emp_id }, obj);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmpoyee(int id,tblemployee obj)
        {
            if (id!= obj.emp_id)
            {
                return BadRequest();
            }
            _context.Entry(obj).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
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

        private bool EmployeeExists(int id)
        {
            return _context.tblemployees.Any(e => e.emp_id == id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<tblemployee>> DeleteEmployee(int id)
        {
            var employee = await _context.tblemployees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.tblemployees.Remove(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

    }
}
