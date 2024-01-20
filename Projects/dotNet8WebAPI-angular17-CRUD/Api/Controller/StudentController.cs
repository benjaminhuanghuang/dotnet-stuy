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
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly AppDbContext _context;

        public StudentController(ILogger<StudentController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("SayHello")]
        public string SayHello()
        {
            return "Hello from StudentController";
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
            if(result > 0)
            {
                return Ok(student);
            }
            return BadRequest();
        }
    }
}
