using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage(null, "ENC1003")]
namespace LiveReloadNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
