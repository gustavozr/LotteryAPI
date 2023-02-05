namespace LotteryAPI.Lottery.Entities
{
    public class BetConfig
    {
        public BetConfig()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public GameRoute GameRoute { get; set; }

        public int AmountOfNumbers { get; set; }

    }
}
