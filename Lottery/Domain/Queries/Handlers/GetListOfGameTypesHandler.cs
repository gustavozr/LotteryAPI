using Dapper;
using LotteryAPI.Data.DapperLottery;
using LotteryAPI.Lottery.Domain.Queries.Requests;
using LotteryAPI.Lottery.Domain.Queries.Responses;
using MediatR;

namespace LotteryAPI.Lottery.Domain.Queries.Handlers
{
    public class GetListOfGameTypesHandler : IRequestHandler<GetListOfGameTypesRequest, GetListOfGameTypesResponse>
    {
        IConfiguration _configuration;
        public GetListOfGameTypesHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<GetListOfGameTypesResponse> Handle(GetListOfGameTypesRequest request, CancellationToken cancellationToken)
        {
            GetListOfGameTypesResponse result = new GetListOfGameTypesResponse();
            using (DapperDBSession dapperDB = new DapperDBSession(_configuration))
            {
                result.games = dapperDB.Connection.Query<string>("SELECT [Description] FROM [ROUTES] ORDER BY [Description]").ToList();

            }
            return Task.FromResult(result);
        }
    }
}
