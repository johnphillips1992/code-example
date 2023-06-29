using AutoMapper;
using LexingtonPreschoolAcademy.Dto;
using LexingtonPreschoolAcademy.Interfaces;
using LexingtonPreschoolAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace LexingtonPreschoolAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : Controller
    {
        private readonly IClassRepository _classRepository;
        private readonly IMapper _mapper;

        public ClassController(IClassRepository classRepository,
            IMapper mapper)
        {
            _classRepository = classRepository;
            // using mapper with Dto to control what we return
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Class>))]
        public IActionResult GetClasses()
        {
            var classes = _mapper.Map<List<ClassDto>>(_classRepository.GetClasses());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(classes);
        }
    }
}
