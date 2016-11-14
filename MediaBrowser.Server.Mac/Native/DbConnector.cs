﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using MediaBrowser.Model.Logging;
using Emby.Server.Core.Data;

namespace MediaBrowser.Server.Mac
{
    public class DbConnector : IDbConnector
    {
        private readonly ILogger _logger;

        public DbConnector(ILogger logger)
        {
            _logger = logger;
        }

        public Task<IDbConnection> Connect(string dbPath, bool isReadOnly, bool enablePooling = false, int? cacheSize = null)
        {
            return SqliteExtensions.ConnectToDb(dbPath, isReadOnly, enablePooling, cacheSize, _logger);
        }
    }
}