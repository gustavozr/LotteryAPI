using static Dapper.SqlMapper;
using System.Data;
using Microsoft.Data.Sqlite;
using Microsoft.AspNetCore.Mvc;

namespace LotteryAPI.Data.DapperLottery
{
    public sealed class DapperDBSession : IDisposable
    {
        private Guid _id;
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }

        public DapperDBSession(IConfiguration config)
        {
            _id = Guid.NewGuid();
            Connection = new SqliteConnection(config.GetConnectionString("sqlite"));
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();
    }
}
