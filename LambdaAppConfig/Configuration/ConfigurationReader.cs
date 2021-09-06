using System;
using Amazon.Extensions.NETCore.Setup;
using Microsoft.Extensions.Configuration;

namespace LambdaAppConfig.Configuration
{
    public static class ConfigurationReader
    {
        private static IConfigurationRoot config;

        public static void Init()
        {
            var appConfig = AwsAppConfigConfiguration.GetFromEnvironmentVariables();
            var configurationBuilder = new ConfigurationBuilder()
                                      .AddEnvironmentVariables()
                                      .AddAppConfig(
                                           appConfig.ApplicationId,
                                           appConfig.EnvironmentId,
                                           appConfig.ConfigProfileId,
                                           new AWSOptions { DefaultClientConfig = { ServiceURL = "http://localhost:2772" } },
                                           appConfig.ConfigReloadTime
                                       );

            config = configurationBuilder.Build();
        }

        public static TestParameters GetTestParameters()
        {
            var testParameters = new TestParameters();
            config.GetSection("TestParameters").Bind(testParameters);
            return testParameters;
        }
    }
}
