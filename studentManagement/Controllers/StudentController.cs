

using Microsoft.AspNetCore.Mvc;
using studentManagement.Model;
using studentManagement.Service;

namespace studentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService) {
            _studentService = studentService;
        }


        [HttpGet]
        public IActionResult GetAllStudent()
        {
           var students= _studentService.GetAllStudents();
            if (students == null)
            {
                return NotFound();
            }else
            {
                return Ok(students);
            }
        }


        [HttpGet("id")]
        public IActionResult GetStudentById(int id) {
            var student = _studentService.getById(id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(student);
            }
        }

        [HttpPost("NewStudent")]
        public IActionResult AddStudent(Student Student)
        {
            var student = _studentService.AddStudent(Student);
            if (student == null)
            {
                return BadRequest();
            }else
            {
                return Ok(student);
            }
        }
    }
}
