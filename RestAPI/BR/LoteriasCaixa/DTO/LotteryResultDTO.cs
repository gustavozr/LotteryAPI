namespace LotteryAPI.RestAPI.BR.LoteriasCaixa.DTO
{
    public class LotteryResultDTO
    {
        public bool acumulado { get; set; }
        public string dataApuracao { get; set; }
        public string dataProximoConcurso { get; set; }
        public List<string> dezenasSorteadasOrdemSorteio { get; set; }
        public bool exibirDetalhamentoPorCidade { get; set; }
        public int? id { get; set; }
        public int indicadorConcursoEspecial { get; set; }
        public List<string> listaDezenas { get; set; }
        public List<string>? listaDezenasSegundoSorteio { get; set; }
        public List<WinnersCityDTO>? listaMunicipioUFGanhadores { get; set; }
        public List<PrizeDTO>? listaRateioPremio { get; set; }
        public List<SportTeamDTO>? listaResultadoEquipeEsportiva { get; set; }
        public string localSorteio { get; set; }
        public string nomeMunicipioUFSorteio { get; set; }
        public string nomeTimeCoracaoMesSorte { get; set; }
        public int numero { get; set; }
        public int numeroConcursoAnterior { get; set; }
        public int numeroConcursoFinal_0_5 { get; set; }
        public int numeroConcursoProximo { get; set; }
        public int numeroJogo { get; set; }
        public string observacao { get; set; }
        public double? premiacaoContingencia { get; set; }
        public string tipoJogo { get; set; }
        public int tipoPublicacao { get; set; }
        public bool ultimoConcurso { get; set; }
        public double valorArrecadado { get; set; }
        public double valorAcumuladoConcurso_0_5 { get; set; }
        public double valorAcumuladoConcursoEspecial { get; set; }
        public double valorAcumuladoProximoConcurso { get; set; }
        public double valorEstimadoProximoConcurso { get; set; }
        public double valorSaldoReservaGarantidora { get; set; }
        public double valorTotalPremioFaixaUm { get; set; }
    }
}
