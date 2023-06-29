using LexingtonPreschoolAcademy.Models;

namespace LexingtonPreschoolAcademy.ViewModels
{
    public class StudentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> ClassIdList { get; set; }
    }
}
