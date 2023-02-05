using LotteryAPI.Lottery.Domain.Queries.Responses;
using MediatR;

namespace LotteryAPI.Lottery.Domain.Queries.Requests
{
    public class GetListOfGameTypesRequest : IRequest<GetListOfGameTypesResponse>
    {
    }
}
