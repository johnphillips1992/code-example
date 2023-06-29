using LexingtonPreschoolAcademy.Data;
using LexingtonPreschoolAcademy.Interfaces;
using LexingtonPreschoolAcademy.Models;
using Microsoft.EntityFrameworkCore;

namespace LexingtonPreschoolAcademy.Repository
{
    public class StudentClassRepository : IStudentClassRepository
    {
        private readonly DataContext _context;

        public StudentClassRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<StudentClass> GetStudentClasses(int studentId)
        {
            return _context.StudentClasses
                        .FromSqlRaw("GetStudentClasses @StudentId = {0}", studentId)
                        .ToList();
        }
    }
}
