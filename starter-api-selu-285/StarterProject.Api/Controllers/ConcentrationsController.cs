using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Features.Concentrations;
using StarterProject.Api.Features.Concentrations.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarterProject.Api.Controllers
{
    [ApiController]
    public class ConcentrationsController : ControllerBase
    {
        private readonly IConcentrationRepository _concentrationRepository;

        public ConcentrationsController(
            IConcentrationRepository concentrationRepostiory)
        {
            _concentrationRepository = concentrationRepostiory;
        }

       
        // GET: api/<controller>
        [HttpGet("[controller]/{concentrationId:int}")]
        [ProducesResponseType(typeof(ConcentrationGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int concentrationId)
        {
            var concentration = _concentrationRepository.GetConcentration(concentrationId);
            return Ok(concentration);
        }

        // GET api/<controller>/5
        [HttpGet("[controller]")]
        [ProducesResponseType(typeof(List<ConcentrationGetDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var concentration = _concentrationRepository.GetAllConcentrations();
            return Ok(concentration);
        }

        // POST api/<controller>
        [HttpPost("[controller]")]
        [ProducesResponseType(typeof(ConcentrationGetDto), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] ConcentrationCreateDto concentrationCreateDto)
        {
            var concentration = _concentrationRepository.CreateConcentration(concentrationCreateDto);
            return Created("[controller]", concentration);
        }

        // PUT api/<controller>/5
        [HttpPut("[controller]/{concentrationId:int}")]
        [ProducesResponseType(typeof(ConcentrationGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Put(int concentrationId, [FromBody] ConcentrationEditDto concentrationEditDto)
        {
            var concentration = _concentrationRepository.EditConcentration(concentrationId, concentrationEditDto);
            return Ok(concentration);
        }

        // DELETE api/<controller>/5
        [HttpDelete("[controller]/{concentrationId:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Delete(int concentrationId)
        {
            _concentrationRepository.DeleteConcentration(concentrationId);
            return Ok();
        }
    }
}
