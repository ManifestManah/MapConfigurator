/////////////////
// - IMPORTS - //
/////////////////

// C# Specific imports
using System;

// CSSharp specific imports
using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;

// Required for being able to use attributes for commands and defining minimum api versions
using CounterStrikeSharp.API.Core.Attributes;


// Specifies the namespace of the plugin, this should match the name of the plugin file
namespace MapConfigurator;

// Defines the minimum version of CounterStrikeSharp required in order to run this plugin on the server 
[MinimumApiVersion(96)]

// Specifies our main class, this should match the name of the namespace
public class MapConfigurator : BasePlugin
{
    // The retrievable information about the plugin itself
    public override string ModuleName => "[Custom] Map Configurator";
    public override string ModuleAuthor => "Manifest @Road To Glory";
    public override string ModuleDescription => "Allow server owners to easily create unique configuration files on a per map basis.";
    public override string ModuleVersion => "V. 1.0.4 [Beta]";
 

    // This happens when the plugin is loaded
    public override void Load(bool hotReload)
    {
        // Taps in to all of the listeners that the plugin will be using
        RegisterListener<Listeners.OnMapStart>(Listener_OnMapStart);

        // Registers and hooks in to the game events we intend to use
        RegisterEventHandler<EventRoundFreezeEnd>(Event_RoundFreezeEnd, HookMode.Post);
    }


    ///////////////////
    // - Listeners - //
    ///////////////////

    // A list of the supported listeners and their names can be found here:
    // -    https://github.com/roflmuffin/CounterStrikeSharp/blob/739dcf4da98dbf16291ef466536d2b27cfd56cdb/managed/CounterStrikeSharp.API/Core/Listeners.g.cs


    // This happens when a new map is loaded
    private void Listener_OnMapStart(string mapName)
    {
        // Calls upon the function that executes the map prefix configuration file
        ExecutePrefixConfigurationFile(mapName);

        // Calls upon the function that executes the map specific configuration file
        ExecuteSpecificMapConfigurationFile(mapName);

        return;
    }


    /////////////////////
    // - Game Events - //
    /////////////////////
    
    // A list of the supported events and their names can be found here:
    // -    https://github.com/roflmuffin/CounterStrikeSharp/blob/739dcf4da98dbf16291ef466536d2b27cfd56cdb/managed/CounterStrikeSharp.API/Core/GameEvents.g.cs


    // This happens when the freeze time has ended
    private HookResult Event_RoundFreezeEnd(EventRoundFreezeEnd @event, GameEventInfo info)
    {
        // Creates a string that specify path and name of the specific map's configuration file 
        string mapFileName = "/mapconfigs/forced/" + NativeAPI.GetMapName() + ".cfg";

        // Adds the command 'execifexists' in front of the file path that we just defined
        string serverCommand = "execifexists " + mapFileName;

        // Executes the specified servercommand and loads the map's .cfg file if it exists
        Server.ExecuteCommand(serverCommand);

        return HookResult.Continue;
    }



    ////////////////////
    /// - Functions - //
    ////////////////////

    // This happens when a new map is loaded
    private void ExecutePrefixConfigurationFile(string mapName)
    {
        // Splits the map's name in to sections where underscore is used
        string[] mapNamePrefix = mapName.Split('_');
        
        // Adds the underscore to the map's prefix
        mapNamePrefix[0] = mapNamePrefix[0] + "_";

        // Creates a string that specify path and name of the prefix configuration file 
        string prefixFileName = "/mapconfigs/prefixes/" + mapNamePrefix[0] + ".cfg";

        // Adds the command 'execifexists' in front of the file path that we just defined
        string serverCommand = "execifexists " + prefixFileName;

        // Executes the specified servercommand and loads the prefix .cfg file if it exists
        Server.ExecuteCommand(serverCommand);
    }


    // This happens when a new map is loaded
    private void ExecuteSpecificMapConfigurationFile(string mapName)
    {
        // Creates a string that specify path and name of the specific map's configuration file 
        string mapFileName = "/mapconfigs/" + mapName + ".cfg";

        // Adds the command 'execifexists' in front of the file path that we just defined
        string serverCommand = "execifexists " + mapFileName;

        // Executes the specified servercommand and loads the map's .cfg file if it exists
        Server.ExecuteCommand(serverCommand);
    }
}