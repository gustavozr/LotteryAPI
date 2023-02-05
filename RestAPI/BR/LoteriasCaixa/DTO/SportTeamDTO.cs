namespace LotteryAPI.RestAPI.BR.LoteriasCaixa.DTO
{
    public class SportTeamDTO
    {
        public string diaSemana { get; set; }
        public string dtJogo { get; set; }
        public int icSorteioResultado { get; set; }
        public string nomeCampeonato { get; set; }
        public string nomeEquipeDois { get; set; }
        public string nomeEquipeUm { get; set; }
        public int nuConcurso { get; set; }
        public int nuGolEquipeDois { get; set; }
        public int nuGolEquipeUm { get; set; }
        public int nuJogo { get; set; }
        public int nuSequencial { get; set; }
        public object resultado { get; set; }
        public string siglaPaisDois { get; set; }
        public string siglaPaisUm { get; set; }
        public string siglaUFDois { get; set; }
        public string siglaUFUm { get; set; }
    }
}
