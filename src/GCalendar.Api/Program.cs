using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace GCalendar.Api
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(params string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
