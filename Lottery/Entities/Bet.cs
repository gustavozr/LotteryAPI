namespace LotteryAPI.Lottery.Entities
{
    public class Bet
    {
        public Bet()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public BetConfig Config { get; set; }
        public List<BetNumber> Numbers { get; set; }

    }
}
