using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Features.Classes;
using StarterProject.Api.Features.Classes.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarterProject.Api.Controllers
{
    [ApiController]
    public class ClassesController : Controller
    {
        private readonly IClassRepository _classRepository;

        public ClassesController(
            IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        // GET: api/<controller>
        [HttpGet("[controller]/{classId:int}")]
        [ProducesResponseType(typeof(ClassGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int classId)
        {
            var classMe = _classRepository.GetClass(classId);
            return Ok(classMe);
        }

        // GET api/<controller>/5
        [HttpGet("[controller]")]
        [ProducesResponseType(typeof(List<ClassGetDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var classMe = _classRepository.GetAllClasses();
            return Ok(classMe);
        }

        // POST api/<controller>
        [HttpPost("[controller]")]
        [ProducesResponseType(typeof(ClassGetDto), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] ClassCreateDto classCreateDto)
        {
            var classMe = _classRepository.CreateClass(classCreateDto);
            return Created("[controller]", classMe);
        }

        // PUT api/<controller>/5
        [HttpPut("[controller]/{classId:int}")]
        [ProducesResponseType(typeof(ClassGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Put(int classId, [FromBody] ClassEditDto classEditDto)
        {
            var classMe = _classRepository.EditClass(classId, classEditDto);
            return Ok(classMe);
        }

        // DELETE api/<controller>/5
        [HttpDelete("[controller]/{classId:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Delete(int classId)
        {
            _classRepository.DeleteClass(classId);
            return Ok();
        }
    }
}
