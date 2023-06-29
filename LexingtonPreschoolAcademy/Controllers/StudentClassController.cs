using AutoMapper;
using LexingtonPreschoolAcademy.Dto;
using LexingtonPreschoolAcademy.Interfaces;
using LexingtonPreschoolAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace LexingtonPreschoolAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassController : Controller
    {
        private readonly IStudentClassRepository _studentClassRepository;
        private readonly IMapper _mapper;

        public StudentClassController(IStudentClassRepository studentClassRepository,
            IMapper mapper)
        {
            _studentClassRepository = studentClassRepository;
            // using mapper with Dto to control what we return
            _mapper = mapper;
        }

        [HttpGet("{studentId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<StudentClass>))]
        public IActionResult GetStudentClasses(int studentId)
        {
            var studentClasses = _mapper.Map<List<StudentClassDto>>(_studentClassRepository.GetStudentClasses(studentId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(studentClasses);
        }
    }
}
