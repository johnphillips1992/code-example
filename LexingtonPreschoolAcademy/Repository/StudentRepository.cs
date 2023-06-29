using LexingtonPreschoolAcademy.Data;
using LexingtonPreschoolAcademy.Dto;
using LexingtonPreschoolAcademy.Interfaces;
using LexingtonPreschoolAcademy.Models;
using LexingtonPreschoolAcademy.ViewModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LexingtonPreschoolAcademy.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public async void CreateStudent(StudentViewModel studentViewModel)
        {
            SqlParameter FirstName = new SqlParameter("@FirstName", studentViewModel.FirstName);
            SqlParameter LastName = new SqlParameter("@LastName", studentViewModel.LastName);
            SqlParameter id = new SqlParameter("id", -1);
            id.Direction = System.Data.ParameterDirection.Output;
            id.DbType = System.Data.DbType.Int32;

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(FirstName); 
            parameters.Add(LastName);
            parameters.Add(id);

            _context.Database.ExecuteSqlRaw("EXEC dbo.CreateStudent @FirstName, @LastName, @id =@id OUTPUT", parameters.ToArray());

            int studentId = Int32.Parse(id.Value.ToString());

            foreach(int classId in studentViewModel.ClassIdList)
            {
                _context.Database.ExecuteSqlRaw("EXEC dbo.AddStudentToClass @StudentId={0}, @ClassId={1}", studentId, classId);
            }
        }

        public Student GetStudent(int id)
        {
            // Execute stored procedure to get a student by id
            return _context.Students
                        .FromSqlRaw("GetStudent @Id = {0}", id)
                        .AsEnumerable()
                        .FirstOrDefault();
        }

        public ICollection<Student> GetStudents()
        {
            // Execute stored procedure to get all students
            return _context.Students
                        .FromSqlRaw("GetStudents")
                        .ToList();
        }
    }
}
