using Microsoft.AspNetCore.Mvc;
using Student.Application.Services;

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
        public ActionResult<IList<Domain.Student>> GetAllStudents()
        {
            return Ok(this._studentService.GetAllStudents());
        }
    }
}
