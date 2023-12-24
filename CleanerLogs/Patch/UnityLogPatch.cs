using HarmonyLib;
using UnityEngine;

namespace CleanerLogs.Patch {
    /*
    class UnityLogPatch {
        static readonly string[] PREFIXES_TO_FILTER_INFO = {
            "dist to target torso degrees",
            "Look rotation viewing vector is zero"
        };
        static readonly string[] PREFIXES_TO_FILTER_WARN = {
            "PlayOneShot was called with a null AudioClip.",
            "BoxColliders does not support negative scale or size.",
            "Audio source failed to initialize audio spatializer."
        };
        static readonly string[] PREFIXES_TO_FILTER_ERROR = {};

        [HarmonyPatch(typeof(Debug))]
        [HarmonyPatch("Log", new System.Type[] {typeof(object)})]
        [HarmonyPrefix]
        public static bool LogInfoPrefixA(object message) {
            // Ignore messages that clog the log.
            foreach (string prefix in PREFIXES_TO_FILTER_INFO) {
                if (message.ToString().StartsWith(prefix)) {
                    return false;
                }
            }

            return true;
        }

        [HarmonyPatch(typeof(Debug))]
        [HarmonyPatch("Log", new System.Type[] {typeof(object), typeof(Object)})]
        [HarmonyPrefix]
        public static bool LogInfoPrefixB(object message, Object context) {
            // Ignore messages that clog the log.
            foreach (string prefix in PREFIXES_TO_FILTER_INFO) {
                if (message.ToString().StartsWith(prefix)) {
                    return false;
                }
            }

            return true;
        }

        [HarmonyPatch(typeof(Debug))]
        [HarmonyPatch("LogWarning", new System.Type[] {typeof(object)})]
        [HarmonyPrefix]
        public static bool LogWarningPrefixA(object message) {
            // Ignore any messages which start with the prefixes above.
            foreach (string prefix in PREFIXES_TO_FILTER_WARN) {
                if (message.ToString().StartsWith(prefix)) {
                    return false;
                }
            }

            return true;
        }

        [HarmonyPatch(typeof(Debug))]
        [HarmonyPatch("LogWarning", new System.Type[] {typeof(object), typeof(Object)})]
        [HarmonyPrefix]
        public static bool LogWarningPrefixB(object message, Object context) {
            // Ignore any messages which start with the prefixes above.
            foreach (string prefix in PREFIXES_TO_FILTER_WARN) {
                if (message.ToString().StartsWith(prefix)) {
                    return false;
                }
            }

            return true;
        }

        [HarmonyPatch(typeof(Debug))]
        [HarmonyPatch("LogError", new System.Type[] {typeof(object)})]
        [HarmonyPrefix]
        public static bool LogErrorPrefixA(object message) {
            // Ignore any messages which start with the prefixes above.
            foreach (string prefix in PREFIXES_TO_FILTER_ERROR) {
                if (message.ToString().StartsWith(prefix)) {
                    return false;
                }
            }

            return true;
        }

        [HarmonyPatch(typeof(Debug))]
        [HarmonyPatch("LogError", new System.Type[] {typeof(object), typeof(Object)})]
        [HarmonyPrefix]
        public static bool LogErrorPrefixB(object message, Object context) {
            // Ignore any messages which start with the prefixes above.
            foreach (string prefix in PREFIXES_TO_FILTER_ERROR) {
                if (message.ToString().StartsWith(prefix)) {
                    return false;
                }
            }

            return true;
        }
    }
    */
}