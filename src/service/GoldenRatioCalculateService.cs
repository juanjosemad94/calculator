using System;
using System.Threading.Tasks;

namespace GoldenRatioCalculator
{
    public class GoldenRatioCalculateService : IGoldenRatioCalculateService
    {
        public async Task<GoldenRatio> GetGoldenRatio(string input)
        {
            return await Task<GoldenRatio>.Run(() =>
            {
                if (decimal.TryParse(input, out decimal ab))
                {
                    decimal a = ab / 1.618M;
                    decimal b = a / 1.618M;
                    return new GoldenRatio { Ab = ab, A = a, B = b };
                }
                else
                {
                    throw new ArgumentException("Please specify a valid input.");
                }
            });
        }
    }
}