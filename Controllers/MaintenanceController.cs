using LotteryAPI.Lottery.Domain.Commands.Requests;
using LotteryAPI.Lottery.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LotteryAPI.Controllers
{
    [ApiController]
    [Route("maintenance")]
    public class MaintenanceController : Controller
    {
        [HttpGet]
        [Route("update")]
        public async Task<IActionResult> Update([FromServices] IMediator mediator)
        {
            try
            {
                ExecuteMigrationRequest request = new ExecuteMigrationRequest();
                ExecuteMigrationResponse response = await mediator.Send(request);
                return NoContent();
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpGet]
        [Route("config")]
        public async Task<IActionResult> Config([FromServices] IMediator mediator)
        {
            try
            {
                ExecuteConfigRequest request = new ExecuteConfigRequest();
                ExecuteConfigResponse response = await mediator.Send(request);
                return NoContent();
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }
    }
}
