using Npgsql;
using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace EvolveExample.DAL
{
    public static class MigrationService
    {

        public static void Migrate(string connectionString, ILogger logger)
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                var evolve = new Evolve.Evolve(connection, message => logger.LogInformation(message))
                {
                    Locations = new List<string> { "db/migrations" },
                    IsEraseDisabled = true,
                };

                evolve.Migrate();
            }
            catch (Exception ex)
            {
                logger.LogCritical("Database migration failed.", ex);
                throw;
            }
        }
    }
}
