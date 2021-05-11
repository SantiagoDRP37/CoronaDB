using CoronaTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public PersonasController(AplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<PersonasController>
        [HttpGet]
        public async Task<IActionResult>  Get()
        {
            try
            {
                var listPersonas = await _context.PacientePersonas.ToListAsync();
                return Ok(listPersonas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //// GET api/<PersonasController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<PersonasController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PacientePersona PacientePersona)
        {
            try
            {
                _context.Add(PacientePersona);
                await _context.SaveChangesAsync();
                return Ok(PacientePersona);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<PersonasController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] PacientePersona PacientePersona)
        {
            try
            {
                if (id != PacientePersona.Id)
                {
                    return NotFound();
                }
                _context.Update(PacientePersona);
                await _context.SaveChangesAsync();
                return Ok(new { message = "La informacion fue actualizada con exito"});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        // DELETE api/<PersonasController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var persona = await _context.PacientePersonas.FindAsync(id);
                if (persona == null)
                {
                    return NotFound();
                }
                _context.PacientePersonas.Remove(persona);
                await _context.SaveChangesAsync();
                return Ok(new { message = "La informacion ha sido borrada con exito" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
