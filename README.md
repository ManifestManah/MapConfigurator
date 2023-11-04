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


## Requirements
In order for the plugin to work, you must have the following installed:
- [CounterStrikeSharp](https://docs.cssharp.dev/guides/getting-started/) 


## Installation
1) Download the contents and open the downloaded zip file.
2) Drag the files within the 'Gameserver' folder into your server's csgo/ directory.
3) Edit the files in cfg/mapconfigs/ folder to match your preferences
4) Restart your server, or change the map.


## Known Bugs & Issues
- None.


## Future development plans
- [ ] Fix any bugs/issues that get reported.


## Bug Reports, Problems & Help
This plugin has been tested and used on a server, there should be no bugs or issues aside from the known ones found here.
Should you run into a bug that isn't listed here, then please report it by creating an issue here on GitHub.
