namespace LotteryAPI.Lottery.Entities
{
    public class GameRoute
    {
        public GameRoute()
        {
            Id = Guid.NewGuid();
        }

        public GameRoute(string description, string route, int startNumber, int endNumber, int amountOfDrawnNumbers, int amountOfNumbersToBet)
        {
            Id = Guid.NewGuid();
            Description = description;
            Route = route;
            StartNumber = startNumber;
            EndNumber = endNumber;
            AmountOfDrawnNumbers = amountOfDrawnNumbers;
            AmountOfNumbersToBet = amountOfNumbersToBet;
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Route { get; set; }

        public int StartNumber { get; set; }
        public int EndNumber { get; set; }
        public int AmountOfDrawnNumbers { get; set; }
        public int AmountOfNumbersToBet { get; set; }

    }
}
