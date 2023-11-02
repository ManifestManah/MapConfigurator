/////////////////
// - IMPORTS - //
/////////////////

// C# Specific imports
using System;

// CSSharp specific imports
using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;


// Specifies the namespace of the plugin, this should match the name of the plugin file
namespace MapConfigurator;


// Specifies our main class, this should match the name of the namespace
public class MapConfigurator : BasePlugin
{
    // The retrievable information about the plugin itself
    public override string ModuleName => "[Custom] Map Configurator";
    public override string ModuleAuthor => "Manifest @Road To Glory";
    public override string ModuleDescription => "Allow server owners to easily create unique configuration files on a per map basis.";
    public override string ModuleVersion => "V. 1.0.1 [Beta]";
 

    // This happens when the plugin is loaded
    public override void Load(bool hotReload)
    {
        // Taps in to all of the listeners that the plugin will be using
        RegisterListener<Listeners.OnMapStart>(Listener_OnMapStart);
    }


    ///////////////////
    // - Listeners - //
    ///////////////////

    // A list of the supported listeners and their names can be found here:
    // -    https://github.com/roflmuffin/CounterStrikeSharp/blob/739dcf4da98dbf16291ef466536d2b27cfd56cdb/managed/CounterStrikeSharp.API/Core/Listeners.g.cs


    // This happens when a new map is loaded
    private void Listener_OnMapStart(string mapName)
    {
        // Creates a string that specify path and name of the specific map's configuration file 
        string mapFileName = "/mapconfigs/" + mapName + ".cfg";

        // Adds the command 'execifexists' in front of the file path that we just defined
        string serverCommand = "execifexists " + mapFileName;

        // Executes the specified servercommand and loads the map's .cfg file if it exists
        Server.ExecuteCommand(serverCommand);

        return;
    }
}