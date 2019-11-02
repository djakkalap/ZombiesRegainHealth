# Zombies Regain Health
This is a simple plugin for the game SCP: Secret Laboratory. It allows SCP-049-2 instances to regain health upon a kill.

## Features
This plugin:
- Gives zombies a configurable amount of HP when they kill somebody.

## Installation
To install, simply place the ```ZombiesRegainHealth.dll``` in the ```sm_plugins``` folder of your server. It requires Smod2 to function.

## Config
| Config key         | Type      | Default | Description                                                        |
|--------------------|:---------:|--------:|--------------------------------------------------------------------|
| `zrh_health_regen` | `int`     | `15`    | This integer determines how much HP the zombies should regenerate. | 
| `zrh_disable`      | `boolean` | `false` | Determines whether to disable the plugin.                          |
