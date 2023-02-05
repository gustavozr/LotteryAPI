namespace LotteryAPI.Lottery.Entities
{
    public class BetNumber
    {
        public BetNumber()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public int Number { get; set; }
    }
}
