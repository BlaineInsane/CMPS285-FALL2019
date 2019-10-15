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

        
        // POST api/<controller>
        [HttpPost]
        [ProducesResponseType(typeof(MajorGetDto), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] MajorCreateDto majorCreateDto)
        {
            var major = _majorRepository.CreateMajor(majorCreateDto);
            return Created("[controller]", major);
        }
        //PUT api/<controller>
        [HttpPut("[controller]/{id:int}")]
        [ProducesResponseType(typeof(MajorGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Put(int id, [FromBody] MajorEditDto majorEditDto)
        {
            var user = _majorRepository.EditMajor(id, majorEditDto);
            return Ok(user);
        }
        // DELETE api/<controller>/5
        [HttpDelete("{majorId:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Delete(int majorId)
        {
            _majorRepository.DeleteMajor(majorId);
            return Ok();
        }
    }
}
