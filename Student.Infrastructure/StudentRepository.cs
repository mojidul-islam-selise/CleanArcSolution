using Student.Application.Repositories;

namespace Student.Infrastructure
{
    public class StudentRepository: IStudentRepository
    {

        public static List<Domain.Student> students = new List<Domain.Student>()
        {
            new Domain.Student()
            {
                Name = "Mojidul Islam",
                Department = "CSE",
                Section = "A",
                Mobile = "01712666631",
                Address = "Dhaka, Bangladesh"
            },
            new Domain.Student()
            {
                Name = "Nayeem Islam",
                Department = "CSE",
                Section = "A",
                Mobile = "01712666631",
                Address = "Dhaka, Bangladesh"
            }
        };

        public List<Domain.Student> GetAllStudents()
        {
            return students;
        }
    }
}
