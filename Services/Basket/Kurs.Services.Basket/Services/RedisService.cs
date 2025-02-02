﻿using StackExchange.Redis;

namespace Kurs.Services.Basket.Services
{
    public class RedisService
    {
        private readonly string _host;

        private readonly int _port;

        private ConnectionMultiplexer _connectionMultiplexer;

        public RedisService(string host, int port)
        {
            _host = host;
            _port = port;
        }

        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");

        public IDatabase GetDatabase(int database = 1) => _connectionMultiplexer.GetDatabase(database);
    }
}
