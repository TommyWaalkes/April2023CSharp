﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoBackend.Models;

namespace ToDoBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoListContext _context;

        public ToDoController(ToDoListContext context)
        {
            _context = context;
        }

        // GET: api/ToDo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDo>>> GetToDos()
        {
          if (_context.ToDos == null)
          {
              return NotFound();
          }
            return await _context.ToDos.ToListAsync();
        }

        // GET: api/ToDo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDo>> GetToDo(int id)
        {
          if (_context.ToDos == null)
          {
              return NotFound();
          }
            var toDo = await _context.ToDos.FindAsync(id);

            if (toDo == null)
            {
                return NotFound();
            }

            return toDo;
        }

        // PUT: api/ToDo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToDo(int id, ToDo toDo)
        {
            if (id != toDo.Id)
            {
                return BadRequest();
            }

            _context.Entry(toDo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoExists(id))
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

        // POST: api/ToDo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ToDo>> PostToDo(ToDo toDo)
        {
          if (_context.ToDos == null)
          {
              return Problem("Entity set 'ToDoListContext.ToDos'  is null.");
          }
            _context.ToDos.Add(toDo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetToDo", new { id = toDo.Id }, toDo);
        }

        // DELETE: api/ToDo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDo(int id)
        {
            if (_context.ToDos == null)
            {
                return NotFound();
            }
            var toDo = await _context.ToDos.FindAsync(id);
            if (toDo == null)
            {
                return NotFound();
            }

            _context.ToDos.Remove(toDo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ToDoExists(int id)
        {
            return (_context.ToDos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
