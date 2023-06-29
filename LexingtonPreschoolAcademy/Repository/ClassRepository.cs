using LexingtonPreschoolAcademy.Data;
using LexingtonPreschoolAcademy.Interfaces;
using LexingtonPreschoolAcademy.Models;
using Microsoft.EntityFrameworkCore;

namespace LexingtonPreschoolAcademy.Repository
{
    public class ClassRepository : IClassRepository
    {
        private readonly DataContext _context;

        public ClassRepository(DataContext context) 
        {
            _context = context;
        }
        public ICollection<Class> GetClasses()
        {
            // Execute stored procedure to get all classes
            return _context.Classes
                        .FromSqlRaw("GetClasses")
                        .ToList();
        }
    }
}
