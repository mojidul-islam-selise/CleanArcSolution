using Student.Domain;

namespace Student.Application.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IReadOnlyList<StudentInfo>> GetAllStudentAsync();
        Task<StudentInfo> CreateStudentAsync(StudentInfo studentInfo);
    }
}
