using System.Threading.Tasks;

namespace GoldenRatioCalculator
{
    public interface IGoldenRatioCalculateService
    {
        Task<GoldenRatio> GetGoldenRatio(string input);
    }
}