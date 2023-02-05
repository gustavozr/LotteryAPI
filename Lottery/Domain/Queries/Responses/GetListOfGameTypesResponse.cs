using LotteryAPI.Lottery.Entities;

namespace LotteryAPI.Lottery.Domain.Queries.Responses
{
    public class GetListOfGameTypesResponse
    {
        public List<string> games { get; set; }
    }
}
