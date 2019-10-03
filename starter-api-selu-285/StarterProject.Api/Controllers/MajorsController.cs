using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Features.Majors;
using StarterProject.Api.Features.Majors.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarterProject.Api.Controllers
{
    [Route("api/[controller]")]
    public class MajorsController : ControllerBase
    {
        private readonly IMajorRepository _majorRepository;

        public MajorsController(
            IMajorRepository majorRepository)
        {
            _majorRepository = majorRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        [ProducesResponseType(typeof(MajorGetDto), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] MajorCreateDto majorCreateDto)
        {
            var major = _majorRepository.CreateMajor(majorCreateDto);
            return Created("[controller]", major);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
