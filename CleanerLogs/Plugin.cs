using BepInEx;

using HarmonyLib;
using BepInEx.Logging;

namespace CleanerLogs
{
    public static class PluginInfo
    {
        public const string PLUGIN_ID = "CleanerLogs";
        public const string PLUGIN_NAME = "CleanerLogs";
        public const string PLUGIN_VERSION = "1.0.0";
        public const string PLUGIN_GUID = "com.elitemastereric.CleanerLogs";
    }

    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Instance { get; private set; }

        public ManualLogSource PluginLogger;
        
        public PluginConfig PluginConfig;

        private void Awake()
        {
            Instance = this;

            PluginLogger = Logger;

            // Apply Harmony patches (if any exist)
            Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);
            harmony.PatchAll();

            // Plugin startup logic
            PluginLogger.LogInfo($"Plugin {PluginInfo.PLUGIN_NAME} ({PluginInfo.PLUGIN_GUID}) is loaded!");
            
            LoadConfig();
            
            PluginLogger.LogWarning($"Base game log messages are being filtered to {PluginConfig.GetLogLevelString()}. This may hinder mod debugging.");

            ApplyConfig();
        }

        private void LoadConfig()
        {
            PluginConfig = new PluginConfig();
            PluginConfig.BindConfig(Config);
        }

        void ApplyConfig() {
            UnityEngine.Debug.unityLogger.filterLogType = PluginConfig.GetLogLevelEnum();
        }
    }
}
