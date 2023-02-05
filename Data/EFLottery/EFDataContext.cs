using LotteryAPI.Lottery.Entities;
using Microsoft.EntityFrameworkCore;

namespace LotteryAPI.Data.EFLottery
{
    public class EFDataContext : DbContext
    {
        IConfiguration _config;
        public EFDataContext(IConfiguration config, DbContextOptions<EFDataContext> options) : base(options) 
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
            optionsBuilder.UseSqlite(_config.GetConnectionString("sqlite"));
        }

        public DbSet<GameRoute> Routes { get; set; }
        public DbSet<DrawnNumber> DrawNumbers { get; set; } = null!;
        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<BetConfig> BetConfigs { get; set; } = null!;
        public DbSet<BetNumber> BetNumbers { get; set; } = null!;
        public DbSet<Bet> Bets { get; set; } = null!;

    }
}
