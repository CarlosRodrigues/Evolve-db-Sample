using EvolveExample.DAL;
using Microsoft.Extensions.Logging;
using System;

namespace EvolveSample.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Starting");

                
                // Get this from the config file or env variables
                // hardcoded for x
                var connectionString = @"User ID=xxxx;Password=xxx;Host=xxxxxxxx;Port=5432;
                Database=Evolve;Pooling=true;MinPoolSize=1;MaxPoolSize=20;";
                
                //ensure the db is up to date
                MigrationService.Migrate(connectionString, new LoggerFactory().CreateLogger("console"));



            Console.WriteLine("Continuing the startup....")
        }
    }
}
