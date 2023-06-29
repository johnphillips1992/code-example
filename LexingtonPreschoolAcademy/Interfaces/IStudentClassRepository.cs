using LexingtonPreschoolAcademy.Models;

namespace LexingtonPreschoolAcademy.Interfaces
{
    public interface IStudentClassRepository
    {
        ICollection<StudentClass> GetStudentClasses(int studentId);
    }
}
