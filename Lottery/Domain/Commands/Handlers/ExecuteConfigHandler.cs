using LotteryAPI.Data.EFLottery;
using LotteryAPI.Lottery.Domain.Commands.Requests;
using LotteryAPI.Lottery.Domain.Commands.Responses;
using LotteryAPI.Lottery.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LotteryAPI.Lottery.Domain.Commands.Handlers
{
    public class ExecuteConfigHandler : IRequestHandler<ExecuteConfigRequest, ExecuteConfigResponse>
    {
        EFDataContext _dbContext;
        public ExecuteConfigHandler(EFDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<ExecuteConfigResponse> Handle(ExecuteConfigRequest request, CancellationToken cancellationToken)
        {
            if (!(_dbContext.Routes.Any()))
            {
                _dbContext.Routes.Add(new GameRoute("Quina", "quina", 1, 80, 5, 5));
                _dbContext.Routes.Add(new GameRoute("Mega-Sena", "megasena", 1, 60, 6, 6));
                _dbContext.Routes.Add(new GameRoute("Dupla Sena", "duplasena", 1, 50, 6, 6));
                _dbContext.Routes.Add(new GameRoute("Lotofácil", "lotofacil", 1, 25, 15, 15));
                _dbContext.Routes.Add(new GameRoute("Lotomania", "lotomania", 0, 99, 20, 50));
                _dbContext.Routes.Add(new GameRoute("Dia De Sorte", "diadesorte", 0, 0, 0, 0));
                _dbContext.Routes.Add(new GameRoute("Timemania", "timemania", 0, 0, 0, 0));
                _dbContext.Routes.Add(new GameRoute("Federal", "federal", 0, 0, 0, 0));
                _dbContext.Routes.Add(new GameRoute("Loteca", "loteca", 0, 0, 0, 0));
                _dbContext.Routes.Add(new GameRoute("Super Sete", "supersete", 0, 0, 0, 0));

                _dbContext.SaveChanges();
            }

            return Task.FromResult(new ExecuteConfigResponse());
        }
    }
}
