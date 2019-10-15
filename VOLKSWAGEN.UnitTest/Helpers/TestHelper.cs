using Microsoft.Extensions.Configuration;
using VOLKSWAGEN.Core.Entities;

namespace VOLKSWAGEN.UnitTest.Helpers
{
    public static class TestHelper
    {
        //https://weblog.west-wind.com/posts/2018/Feb/18/Accessing-Configuration-in-NET-Core-Test-Projects
        public static IConfigurationRoot GetIConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }
    }
}
