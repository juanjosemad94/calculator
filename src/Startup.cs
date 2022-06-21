using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(GoldenRatioCalculator.Startup))]

namespace GoldenRatioCalculator
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IGoldenRatioCalculateService>((grc) =>
            {
                return new GoldenRatioCalculateService();
            });
        }
    }
}