using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HelloWorld.BitcoinOps
{
    public class BitcoinPriceCheck : IBitcoinPriceCheck
    {
        private const string PRICE_URL = "https://api.coingecko.com/api/v3/simple/price";
        
        public async Task<BitcoinPrice> Execute()
        {
            using var httpClient = new HttpClient {BaseAddress = new Uri(PRICE_URL)};
            var res = await httpClient.GetAsync("?ids=bitcoin&vs_currencies=usd&include_24hr_change=true");

            var update = JsonConvert.DeserializeObject<BitcoinPriceResponse>(await res.Content.ReadAsStringAsync());
            return update.BitcoinPrice;
        }
    }
}