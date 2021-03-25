using Newtonsoft.Json;

namespace HelloWorld.BitcoinOps
{
    public class BitcoinPriceResponse
    {
        [JsonProperty("bitcoin")] public BitcoinPrice BitcoinPrice { get; set; }
    }
}