using System.Collections.Generic;
using marsRover.Entities;
using marsRover.Interfaces;
using marsRover.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace marsRover.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoversController : ControllerBase
    {
        private readonly IRoverService _roverService;

        public RoversController(IRoverService roverService)
        {
            _roverService = roverService;
        }

        [HttpPost]
        public ActionResult<List<Rover>> ExecuteTheRoversMission([FromBody]RoversMissionParams missionParams)
        {
            return _roverService.ExecuteTheMission(missionParams.RoversWithTheirInstructions);
        }
    }
}
