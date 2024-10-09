using Microsoft.AspNetCore.Mvc;
using Student.Application.Services.Interfaces;
using Student.Domain;

namespace Student.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<StudentInfo>>> GetAllStudents()
        {
            return Ok(await _studentService.GetAllStudentAsync());
        }

        [HttpPost]
        public async Task<ActionResult<StudentInfo>> CreateStudent(StudentInfo student)
        {
            return Ok(await _studentService.CreateStudentAsync(student));
        }
    }
}
