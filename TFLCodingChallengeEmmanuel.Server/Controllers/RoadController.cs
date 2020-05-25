using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Interface;

namespace TFLCodingChallengeEmmanuel.Server.Controllers
{
    [Route("Road/{Id}")]
    [Produces("application/json")]
    [ApiController]
    public class RoadController : ControllerBase
    {
        private readonly IRoadService _roadService;

        public RoadController(IRoadService roadService)
        {
            _roadService = roadService;
        }

        [HttpGet]
        public async Task<ActionResult> GetRoadStatus(string Id)
        {
            var result = await _roadService.RoadStatusService(Id);
            if (result == null)
               return NotFound($"{Id} is not a valid road");
            return Ok($"The status of the {result.DisplayName} is as follows; Road Status is {result.StatusSeverity}. Road Status Description is {result.StatusSeverityDescription}");
        }
    }
}
