using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Features.UsersClasses;
using StarterProject.Api.Features.UsersClasses.Dtos;
using System.Collections.Generic;
using System.Net;


namespace StarterProject.Api.Controllers
{
    [ApiController]
    public class UsersClassesController : ControllerBase
    {
        private readonly IUserClassRepository _userClassRepository;

        public UsersClassesController(
            IUserClassRepository userClassRepostiory)
        {
            _userClassRepository = userClassRepostiory;
        }


        // GET: api/<controller>
        [HttpGet("[controller]/{userClassId:int}")]
        [ProducesResponseType(typeof(UserClassGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int userClassId)
        {
            var userClass = _userClassRepository.GetUserClass(userClassId);
            return Ok(userClass);
        }

        // GET api/<controller>/5
        [HttpGet("[controller]")]
        [ProducesResponseType(typeof(List<UserClassGetDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var userClass = _userClassRepository.GetAllUsersClasses();
            return Ok(userClass);
        }

        // POST api/<controller>
        [HttpPost("[controller]")]
        [ProducesResponseType(typeof(UserClassGetDto), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] UserClassCreateDto userClassCreateDto)
        {
            var userClass = _userClassRepository.CreateUserClass(userClassCreateDto);
            return Created("[controller]", userClass);
        }

        // PUT api/<controller>/5
        [HttpPut("[controller]/{userClassId:int}")]
        [ProducesResponseType(typeof(UserClassGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Put(int userClassId, [FromBody] UserClassEditDto userClassEditDto)
        {
            var userClass = _userClassRepository.EditUserClass(userClassId, userClassEditDto);
            return Ok(userClass);
        }

        // DELETE api/<controller>/5
        [HttpDelete("[controller]/{userClassId:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Delete(int userClassId)
        {
            _userClassRepository.DeleteUserClass(userClassId);
            return Ok();
        }
    }
}