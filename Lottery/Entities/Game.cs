using System.Diagnostics;

namespace LotteryAPI.Lottery.Entities
{
    public class Game
    {
        public Game()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public int GameNumber { get; set; }
        public DateTime ResultDate { get; set; }
        public int SpecialGame { get; set; }

        public GameRoute GameRoute { get; set; }

        public float Amount { get; set; }
        public bool HasWinner { get; set; }

        public List<DrawnNumber> Numbers { get; set; }
    }
}
