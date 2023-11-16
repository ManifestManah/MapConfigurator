# [Map Configurator]
## About
With the MapConfigurator plugin installed, and running on your server. 
You will be able to quickly and easily create unique configuration files on a per-map basis.

The specific map's configuration file will be loaded once the map is fully loaded if the map has a file.
Because of this, what you specify within the map's unique configuration file will overwrite any existing value that, has been added in either the server.cfg or the currently used game mode configuration file.
This allows you to simply add the variables that you wish to use for the specific map, without worrying about conflicts.

The map-specific configurations can be found in the server's csgo/cfg/mapconfigs/ folder.
Files for all currently available maps are already been created but without any variables added to them.

If you wish to add a configuration for a new map, simply create a configuration file with that map's name, and it will be loaded the next time the map is played.

If you wish to add a configuration that is applied to all maps starting with the prefix de_ then create a configuration file named "de_" inside of the cfg/mapconfigs/prefixes/ directory, and specify the server variables you wish to have applied for that type of maps.

If you have a map that overwrites a value when the round starts, you can create a file with that map's name inside of cfg/mapconfigs/forced/. But do only do this, if it is absolutely necessary, as map files located in this directory are executed every time the round starts, right after the freeze time ends.
If the server does not use freeze time this will be called right after the round starts, but for the most parts, still late enough for the configuration to overwrite the variable that the map sets when a new round begins.


## Requirements
In order for the plugin to work, you must have the following installed:
- [CounterStrikeSharp](https://docs.cssharp.dev/guides/getting-started/) 


## Installation
1) Download the contents and open the downloaded zip file.
2) Drag the files within the 'csgo' folder into your server's csgo/ directory.
3) Edit the files in cfg/mapconfigs/ folder and sub folders to match your preferences
4) Restart your server, or change the map.


## Known Bugs & Issues
- None.


## Future development plans
- [ ] Fix any bugs/issues that get reported.


## Bug Reports, Problems & Help
This plugin has been tested and used on a server, there should be no bugs or issues aside from the known ones found here.
Should you run into a bug that isn't listed here, then please report it by creating an issue here on GitHub.
