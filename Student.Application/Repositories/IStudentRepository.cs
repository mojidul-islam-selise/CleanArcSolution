namespace Student.Application.Repositories
{
    public interface IStudentRepository
    {
        List<Domain.Student> GetAllStudents();
    }
}
