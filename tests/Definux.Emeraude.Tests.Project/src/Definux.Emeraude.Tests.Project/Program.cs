using System;
using System.Threading.Tasks;
using Emeraude;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Definux.Emeraude.Tests.Project
{
    public class Program : EmProgram
    {
        public static async Task Main(string[] args)
        {
            await RunEmeraudeAsync(CreateHostBuilder(args));
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel();
                    webBuilder.UseStaticWebAssets();
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}
