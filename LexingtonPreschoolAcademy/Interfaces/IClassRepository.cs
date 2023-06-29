using LexingtonPreschoolAcademy.Models;

namespace LexingtonPreschoolAcademy.Interfaces
{
    public interface IClassRepository
    {
        ICollection<Class> GetClasses();
    }
}
