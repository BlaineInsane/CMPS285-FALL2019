using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Features.Concentrations;
using StarterProject.Api.Features.Concentrations.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarterProject.Api.Controllers
{
    [Route("api/[controller]")]
    public class ConcentrationsController : ControllerBase
    {
        private readonly IConcentrationRepository _concentrationRepository;

        public ConcentrationsController(
            IConcentrationRepository concentrationRepostiory)
        {
            _concentrationRepository = concentrationRepostiory;
        }

       

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody] ConcentrationCreateDto concentrationCreateDto)
        {
            var concentration = _concentrationRepository.CreateConcentration(concentrationCreateDto);
            return Created("[controller]", concentration);
        }

    }
}
