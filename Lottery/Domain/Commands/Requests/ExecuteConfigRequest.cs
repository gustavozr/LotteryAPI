using LotteryAPI.Lottery.Domain.Commands.Responses;
using MediatR;

namespace LotteryAPI.Lottery.Domain.Commands.Requests
{
    public class ExecuteConfigRequest : IRequest<ExecuteConfigResponse>
    {
    }
}
