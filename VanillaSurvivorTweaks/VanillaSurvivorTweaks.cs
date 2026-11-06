using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using System;

namespace VanillaSurvivorTweaks
{

    //This is an example plugin that can be put in BepInEx/plugins/ExamplePlugin/ExamplePlugin.dll to test out.
    //It's a small plugin that adds a relatively simple item to the game, and gives you that item whenever you press F2.

    //This attribute is required, and lists metadata for your plugin.
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]

    //This is the main declaration of our plugin class. BepInEx searches for all classes inheriting from BaseUnityPlugin to initialize on startup.
    //BaseUnityPlugin itself inherits from MonoBehaviour, so you can use this as a reference for what you can declare and use in your plugin class: https://docs.unity3d.com/ScriptReference/MonoBehaviour.html
    public class VanillaSurvivorTweaks : BaseUnityPlugin
    {
        //The Plugin GUID should be a unique ID for this plugin, which is human readable (as it is used in places like the config).
        //If we see this PluginGUID as it is on thunderstore, we will deprecate this mod. Change the PluginAuthor and the PluginName !
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "OakPrime";
        public const string PluginName = "VanillaSurvivorTweaks";
        public const string PluginVersion = "0.1.0";

        public static ManualLogSource logger;

        //The Awake() method is run at the very start when the game is initialized.
        public void Awake()
        {
            logger = Logger;
            Log.Init(logger);
            try
            {
                Init();
            }
            catch (Exception e)
            {
                Logger.LogError(e.Message + " - " + e.StackTrace);
            }
        }

        private void Init()
        {
            var configFile = new ConfigFile(Paths.ConfigPath + "\\OakPrime.VanillaSurvivorTweaks.cfg", true);
            //File.TryInit(configFile);
        }
    }
}
