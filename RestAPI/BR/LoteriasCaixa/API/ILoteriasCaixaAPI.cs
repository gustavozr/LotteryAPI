using LotteryAPI.RestAPI.BR.LoteriasCaixa.DTO;

namespace LotteryAPI.RestAPI.BR.LoteriasCaixa.API
{
    public interface ILoteriasCaixaAPI
    {
        public Task<LotteryResultDTO> getLotteryContestInfo(string? game, int? gameId);
    }
}
