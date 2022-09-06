using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace DevOpsChallenge.SalesApi.Database
{
    /// <summary>
    /// Design time factory for the database context.
    /// </summary>
    public class DatabaseContextDesignTimeFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        /// <inheritdoc />
        public DatabaseContext CreateDbContext(string[] args)
        {
            string connectionString = Environment.GetEnvironmentVariable("CONNECTIONSTRINGS__DATABASE") ?? @"Server=.;Database=tempdb;User Id=sa;Password=c0MplicatedP@ssword;ConnectRetryCount=1";

            DbContextOptionsBuilder<DatabaseContext> optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>()
                .UseSqlServer(connectionString);

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
