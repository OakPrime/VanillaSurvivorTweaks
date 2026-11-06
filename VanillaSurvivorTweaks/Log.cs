using BepInEx.Logging;
using MonoMod.Cil;

namespace VanillaSurvivorTweaks
{
    internal class Log
    {
        internal static ManualLogSource _logSource;

        private string _classNameTag;

        internal Log(string className)
        {
            _classNameTag = "[" + className + "] ";
        }

        internal static void Init(ManualLogSource logSource)
        {
            _logSource = logSource;
        }

        internal void LogDebug(object data) => _logSource.LogDebug(_classNameTag + data);
        internal void LogError(object data) => _logSource.LogError(_classNameTag + data);
        internal void LogFatal(object data) => _logSource.LogFatal(_classNameTag + data);
        internal void LogInfo(object data) => _logSource.LogInfo(_classNameTag + data);
        internal void LogMessage(object data) => _logSource.LogMessage(_classNameTag + data);
        internal void LogWarning(object data) => _logSource.LogWarning(_classNameTag + data);

        internal void LogInstrNotFound(ILContext il)
        {
            LogError("GoToNext instructions not found at method: " + il.Method);
        }
    }
}