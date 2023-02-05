namespace LotteryAPI.RestAPI.BR.LoteriasCaixa.DTO
{
    public class PrizeDTO
    {
        public string descricaoFaixa { get; set; }
        public int faixa { get; set; }
        public int numeroDeGanhadores { get; set; }
        public double valorPremio { get; set; }
    }
}
