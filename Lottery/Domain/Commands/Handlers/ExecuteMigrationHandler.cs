using LotteryAPI.Data.EFLottery;
using LotteryAPI.Lottery.Domain.Commands.Requests;
using LotteryAPI.Lottery.Domain.Commands.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LotteryAPI.Lottery.Domain.Commands.Handlers
{
    public class ExecuteMigrationHandler : IRequestHandler<ExecuteMigrationRequest, ExecuteMigrationResponse>
    {
        EFDataContext _dbContext;
        public ExecuteMigrationHandler(EFDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<ExecuteMigrationResponse> Handle(ExecuteMigrationRequest request, CancellationToken cancellationToken)
        {
            _dbContext.Database.Migrate();
            return Task.FromResult(new ExecuteMigrationResponse());
        }
    }
}
