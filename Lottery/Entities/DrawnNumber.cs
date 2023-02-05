namespace LotteryAPI.Lottery.Entities
{
    public class DrawnNumber
    {
        public DrawnNumber()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public int Number { get; set; }
        public int DrawnOrder { get; set; }
    }
}
