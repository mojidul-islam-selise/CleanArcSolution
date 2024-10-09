using Student.Domain;

namespace Student.Application.Repositories
{
    public interface IStudentRepository
    {
        Task<IReadOnlyList<StudentInfo>> GetAllStudentAsync();
        Task<StudentInfo> GetByIdAsync(int id);
        Task<StudentInfo> CreateStudentAsync(StudentInfo studentInfo);
        Task<StudentInfo> UpdateStudentAsync(StudentInfo studentInfo);
        Task<bool> DeleteByIdAsync(int id);
    }
}
