using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Features.Majors;
using StarterProject.Api.Features.Majors.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarterProject.Api.Controllers
{
    [ApiController]
    public class MajorsController : ControllerBase
    {
        private readonly IMajorRepository _majorRepository;

        public MajorsController(
            IMajorRepository majorRepository)
        {
            _majorRepository = majorRepository;
        }

        // GET: api/<controller>
        [HttpGet("[controller]/{majorId:int}")]
        [ProducesResponseType(typeof(MajorGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int majorId)
        {
            var major = _majorRepository.GetMajor(majorId);
            return Ok(major);
        }

        // GET api/<controller>/5
        [HttpGet("[controller]")]
        [ProducesResponseType(typeof(List<MajorGetDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var majors = _majorRepository.GetAllMajors();
            return Ok(majors);
        }

        // POST api/<controller>
        [HttpPost("[controller]")]
        [ProducesResponseType(typeof(MajorGetDto), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] MajorCreateDto majorCreateDto)
        {
            var major = _majorRepository.CreateMajor(majorCreateDto);
            return Created("[controller]", major);
        }

        // PUT api/<controller>/5
        [HttpPut("[controller]/{majorId:int}")]
        [ProducesResponseType(typeof(MajorGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Put(int majorId, [FromBody] MajorEditDto majorEditDto)
        {
            var major = _majorRepository.EditMajor(majorId, majorEditDto);
            return Ok(major);
        }

        // DELETE api/<controller>/5
        [HttpDelete("[controller]/{majorId:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Delete(int majorId)
        {
            _majorRepository.DeleteMajor(majorId);
            return Ok();
        }
    }
}