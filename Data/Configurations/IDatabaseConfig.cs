﻿namespace TaskManager.Data.Configurations
{
    public interface IDatabaseConfig
    {
        string DatabaseName { get; set; }

        string ConnectionUri { get; set; }
    }
}
