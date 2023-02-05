using LotteryAPI.RestAPI.BR.LoteriasCaixa.API;
using LotteryAPI.RestAPI.BR.LoteriasCaixa.Domain.Queries.Requests;
using LotteryAPI.RestAPI.BR.LoteriasCaixa.Domain.Queries.Responses;
using MediatR;

namespace LotteryAPI.RestAPI.BR.LoteriasCaixa.Domain.Queries.Handlers
{
    public class GetGameHandler : IRequestHandler<GetGameRequest, GetGameResponse>
    {
        ILoteriasCaixaAPI _loteriasCaixa;

        public GetGameHandler(ILoteriasCaixaAPI loteriasCaixa)
        {
            _loteriasCaixa = loteriasCaixa;
        }

        public Task<GetGameResponse> Handle(GetGameRequest request, CancellationToken cancellationToken)
        {
            var result = new GetGameResponse();
            result.LotteryResult = _loteriasCaixa.getLotteryContestInfo(request.Game, request.GameId).Result;
            return Task.FromResult(result);
        }
    }
}
