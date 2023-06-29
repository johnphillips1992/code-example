using LexingtonPreschoolAcademy.Data;
using LexingtonPreschoolAcademy.Models;

namespace LexingtonPreschoolAcademy
{
    public class Seed
    {
        private readonly DataContext _context;
        public Seed(DataContext context)
        {
            _context = context;
        }
        public void SeedDataContext()
        {
            // Create initial students
            if (!_context.Students.Any())
            {
                var students = new List<Student>()
                {
                    new Student()
                    {
                        FirstName = "John",
                        LastName = "Doe"
                    },
                    new Student()
                    {
                        FirstName = "Michael",
                        LastName = "Jordan"
                    },
                    new Student()
                    {
                        FirstName = "Scottie",
                        LastName = "Pippen"
                    },
                    new Student()
                    {
                        FirstName = "Steve",
                        LastName = "Kerr"
                    },
                    new Student()
                    {
                        FirstName = "Dennis",
                        LastName = "Rodman"
                    }
                };
                _context.Students.AddRange(students);
                _context.SaveChanges();
            }
            // Create initial classes
            if (!_context.Classes.Any())
            {
                var classes = new List<Class>()
                {
                    new Class()
                    {
                        Name = "Art"
                    },
                    new Class()
                    {
                        Name = "Math"
                    },
                    new Class()
                    {
                        Name = "Science"
                    },
                    new Class()
                    {
                        Name = "History"
                    },
                    new Class()
                    {
                        Name = "Spanish"
                    },
                    new Class()
                    {
                        Name = "P.E."
                    }
                };
                _context.Classes.AddRange(classes);
                _context.SaveChanges();
            }
        }
    }
}