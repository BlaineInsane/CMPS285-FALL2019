using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Features.ClassesConcentrations;
using StarterProject.Api.Features.ClassesConcentrations.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarterProject.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClassesConcentrationsController : ControllerBase
    {
        private readonly IClassConcentrationRepository _classConcentrationRepository;

        public ClassesConcentrationsController(
            IClassConcentrationRepository classConcentrationRepository)
        {
            _classConcentrationRepository = classConcentrationRepository;
        }

       

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody] ClassConcentrationCreateDto classConcentrationCreateDto)
        {
            var classConcentration = _classConcentrationRepository.CreateClassConcentration(classConcentrationCreateDto);
            return Created("[controller]", classConcentration);
        }

        

       
    }
}
