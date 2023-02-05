using LotteryAPI.RestAPI.BR.LoteriasCaixa.Domain.Queries.Responses;
using MediatR;

namespace LotteryAPI.RestAPI.BR.LoteriasCaixa.Domain.Queries.Requests
{
    public class GetGameRequest : IRequest<GetGameResponse>
    {
        public string? Game { get; set; }
        public int? GameId { get; set; }

        public GetGameRequest(string? game, int? gameId)
        {
            Game = game;
            GameId = gameId;
        }

    }
}
