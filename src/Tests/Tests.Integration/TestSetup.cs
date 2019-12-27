using System;
using System.Collections.Generic;
using GCalendar.Api;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Tests.Integration
{
    public class TestSetup
    {
        public TestSetup()
        {
            var settings = new Dictionary<string, string>();           

            var builder = Program.CreateHostBuilder()
                .ConfigureWebHostDefaults(builder => 
                {
                    builder.UseTestServer();
                })
                .ConfigureAppConfiguration((ctx, builder) =>
                    builder.AddInMemoryCollection(settings));
            
            var host = builder.Start();
            var server = host.GetTestServer();
            server.AllowSynchronousIO = true;

            var serviceProvider = server.Host.Services;

            var client = server.CreateClient();
        }
    }
}