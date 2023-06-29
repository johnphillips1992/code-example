using LexingtonPreschoolAcademy.Dto;
using LexingtonPreschoolAcademy.Models;
using LexingtonPreschoolAcademy.ViewModels;

namespace LexingtonPreschoolAcademy.Interfaces
{
    public interface IStudentRepository
    {
        ICollection<Student> GetStudents();
        Student GetStudent(int id);
        void CreateStudent(StudentViewModel studentViewModel);
    }
}
