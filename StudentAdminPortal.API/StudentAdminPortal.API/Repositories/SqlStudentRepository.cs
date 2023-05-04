using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {

        private readonly StudentAdminContext context;
        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }
        public Task<Student> AddStudent(Student request)
        {
            throw new NotImplementedException();
        }

        public Task<Student> DeleteStudent(Guid studentId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Guid studentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Gender>> GetGendersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentAsync(Guid studentId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

        public Task<bool> UpdateProfileImage(Guid studentId, string profileImageUrl)
        {
            throw new NotImplementedException();
        }

        public Task<Student> UpdateStudent(Guid studentId, Student request)
        {
            throw new NotImplementedException();
        }
    }
}
