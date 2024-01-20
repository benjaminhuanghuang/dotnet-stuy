using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

using Api.Data;
using Api.Models;

namespace Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly AppDbContext _context;

        public StudentsController(ILogger<StudentsController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("SayHello")]
        public string SayHello()
        {
            return "Hello from StudentsController";
        }

        [HttpGet("GetAllStudents")]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _context.Students.ToListAsync();
            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _context.AddAsync(student);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return Ok(student);
            }
            return BadRequest();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student is null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student is null)
            {
                return NotFound();
            }
            _context.Remove(student);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return Ok("student deleted successfully");
            }
            return BadRequest("Unable to delete student");
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> EditStudent(int id, Student student)
        {
            var studentFromDb = await _context.Students.FindAsync(id);
            if (studentFromDb is null)
            {
                return NotFound();
            }

            studentFromDb.Name = student.Name;
            studentFromDb.Address = student.Address;
            studentFromDb.Email = student.Email;
            studentFromDb.PhoneNumber = student.PhoneNumber;

            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return Ok("student updated successfully");
            }
            return BadRequest("Unable to update student");
        }
    }
}
