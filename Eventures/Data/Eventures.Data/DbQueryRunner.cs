﻿namespace Eventures.Data
{
    using System;
    using System.Threading.Tasks;

    using Eventures.Data.Common;

    using Microsoft.EntityFrameworkCore;

    public class DbQueryRunner : IDbQueryRunner
    {
        public DbQueryRunner(EventureDbContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public EventureDbContext Context { get; set; }

        public Task RunQueryAsync(string query, params object[] parameters)
        {
            return this.Context.Database.ExecuteSqlCommandAsync(query, parameters);
        }

        public void Dispose()
        {
            this.Context?.Dispose();
        }
    }
}
