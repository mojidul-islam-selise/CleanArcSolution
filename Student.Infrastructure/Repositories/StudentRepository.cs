using Microsoft.EntityFrameworkCore;
using Student.Application.Repositories;
using Student.Domain;

namespace Student.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<StudentInfo> CreateStudentAsync(StudentInfo studentInfo)
        {
            await _dbContext.AddAsync(studentInfo);
            await _dbContext.SaveChangesAsync();
            return studentInfo;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var studentInfo = await _dbContext.StudentInfo.FindAsync(id);
            if(studentInfo != null)
            {
                _dbContext.StudentInfo.Remove(studentInfo);
                return true;
            }
            return false;
        }

        public async Task<IReadOnlyList<StudentInfo>> GetAllStudentAsync()
        {
            return await _dbContext.StudentInfo.ToListAsync();
        }

        public async Task<StudentInfo> GetByIdAsync(int id)
        {
            var studentInfo = await _dbContext.StudentInfo.FindAsync(id);
            return studentInfo == null ? new StudentInfo() : studentInfo;
        }

        public async Task<StudentInfo> UpdateStudentAsync(StudentInfo studentInfo)
        {
            _dbContext.Attach<StudentInfo>(studentInfo);
            _dbContext.Entry(studentInfo).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return studentInfo;
        }
    }
}
