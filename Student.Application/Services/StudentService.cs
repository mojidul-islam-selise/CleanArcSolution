using Student.Application.Repositories;

namespace Student.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentrepository;
        public StudentService(IStudentRepository studentrepository)
        {
            this._studentrepository = studentrepository;
        }
        public List<Domain.Student> GetAllStudents()
        {
            return _studentrepository.GetAllStudents();
        }
    }
}
