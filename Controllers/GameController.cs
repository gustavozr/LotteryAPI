using LotteryAPI.Lottery.Domain.Queries.Requests;
using LotteryAPI.Lottery.Domain.Queries.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LotteryAPI.Controllers
{
    [ApiController]
    [Route("games")]
    public class GameController : Controller
    {
        [HttpGet]
        [Route("games")]
        public async Task<IActionResult> GetAllGames([FromServices] IMediator mediator)
        {
            GetListOfGameTypesRequest request = new GetListOfGameTypesRequest();
            GetListOfGameTypesResponse response = await mediator.Send(request);
            return Ok(response.games);
        }
    }
}
