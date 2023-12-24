using BepInEx.Configuration;
using UnityEngine;

namespace CleanerLogs
{
    public class PluginConfig
    {
        ConfigEntry<string> LogLevel;

        // Constructor
        public PluginConfig()
        {
        }

        // Bind config values to fields
        public void BindConfig(ConfigFile _config)
        {
            LogLevel = _config.Bind("General", "LogLevel", "Warning", "The log level to use (Log, Warning, Assert, Error, Exception)");
        }

        public string GetLogLevelString()
        {
            return LogLevel.Value;
        }

        public LogType GetLogLevelEnum() {
            switch (LogLevel.Value.ToLower()) {
                case "log":
                    return LogType.Log;
                case "warning":
                    return LogType.Warning;
                case "assert":
                    return LogType.Assert;
                case "error":
                    return LogType.Error;
                case "exception":
                    return LogType.Exception;
                default:
                    return LogType.Warning;
            }
        }
    }
}
