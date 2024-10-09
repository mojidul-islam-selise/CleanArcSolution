using Student.Application.Repositories;
using Student.Application.Services.Interfaces;
using Student.Domain;

namespace Student.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentrepository;
        public StudentService(IStudentRepository studentrepository)
        {
            this._studentrepository = studentrepository;
        }

        public async Task<StudentInfo> CreateStudentAsync(StudentInfo studentInfo)
        {
            return await _studentrepository.CreateStudentAsync(studentInfo);
        }

        public async Task<IReadOnlyList<StudentInfo>> GetAllStudentAsync()
        {
            return await _studentrepository.GetAllStudentAsync();
        }
    }
}
