using AutoMapper;
using LexingtonPreschoolAcademy.Dto;
using LexingtonPreschoolAcademy.Interfaces;
using LexingtonPreschoolAcademy.Models;
using LexingtonPreschoolAcademy.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace LexingtonPreschoolAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentController(IStudentRepository studentRepository,
            IMapper mapper)
        {
            _studentRepository = studentRepository;
            // using mapper with Dto to control what we return
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Student>))]
        public IActionResult GetStudents()
        {
            var students = _mapper.Map<List<StudentDto>>(_studentRepository.GetStudents());
            
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(students);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Student))]
        public IActionResult GetStudent(int id)
        {
            var student = _mapper.Map<StudentDto>(_studentRepository.GetStudent(id));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(student);
        }

        [HttpPost]
        [Route("Default/Insert")]
        public IActionResult Insert([FromBody] StudentViewModel studentViewModel) 
        {
            _studentRepository.CreateStudent(studentViewModel);
            return Ok();
        }
    }
}
