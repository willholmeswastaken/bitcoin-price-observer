using System.Threading.Tasks;

namespace HelloWorld.BitcoinOps
{
    public interface IBitcoinPriceCheck
    {
        Task<BitcoinPrice> Execute();
    }
}