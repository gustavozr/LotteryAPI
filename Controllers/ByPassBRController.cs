using LotteryAPI.RestAPI.BR.LoteriasCaixa.Domain.Queries.Requests;
using LotteryAPI.RestAPI.BR.LoteriasCaixa.Domain.Queries.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LotteryAPI.Controllers
{
    [ApiController]
    [Route("br/bypass")]
    public class ByPassBRController : Controller
    {
        [HttpGet]
        [Route("{game?}/{gameId?}")]
        public async Task<IActionResult> GetGame(
            [FromServices] IMediator mediator,
            string? game, int? gameId)
        {
            try
            {
                GetGameRequest request = new GetGameRequest(game, gameId);
                GetGameResponse response = await mediator.Send(request);
                return Ok(response.LotteryResult);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }
    }
}
