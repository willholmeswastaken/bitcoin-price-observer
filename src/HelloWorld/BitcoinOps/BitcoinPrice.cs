using Newtonsoft.Json;

namespace HelloWorld.BitcoinOps
{
    public class BitcoinPrice
    {
        [JsonProperty("usd")]
        public decimal Current { get; set; }

        [JsonProperty("usd_24h_change")]
        public decimal LastDayChange { get; set; }
    }
}