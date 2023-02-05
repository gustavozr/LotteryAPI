using LotteryAPI.RestAPI.BR.LoteriasCaixa.DTO;
using Newtonsoft.Json;
using RestSharp;

namespace LotteryAPI.RestAPI.BR.LoteriasCaixa.API
{
    public class LoteriasCaixaAPI : ILoteriasCaixaAPI
    {
        private IConfiguration _config;

        public LoteriasCaixaAPI(IConfiguration config)
        {
            _config = config;
        }

        public async Task<LotteryResultDTO> getLotteryContestInfo(string? game, int? gameId)
        {
            string strContest = (String.IsNullOrEmpty(game) ? "megasena" : game);
            string strNumber = (gameId ?? 0) <= 0 ? "" : gameId.ToString();
            if (!String.IsNullOrEmpty(strNumber)) strContest += "//{gameId}";

            UriBuilder uri = new UriBuilder();
            uri.Scheme = _config.GetValue<string>("br.loteriascaixa.api:Scheme");
            uri.Host = _config.GetValue<string>("br.loteriascaixa.api:Host");
            uri.Path = _config.GetValue<string>("br.loteriascaixa.api:Path");

            try
            {
                RestClient client = new RestClient(uri.Uri);

                RestRequest request = new RestRequest(strContest, Method.Get);
                if (!String.IsNullOrEmpty(strNumber)) request.AddUrlSegment("number", strNumber);
                request.AddHeader("Accept", "application/json");

                RestResponse<LotteryResultDTO> response = await client.ExecuteAsync<LotteryResultDTO>(request);

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<LotteryResultDTO>(response.Content);
                }
                else
                {
                    throw new Exception(response.Content);
                }
            } 
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
