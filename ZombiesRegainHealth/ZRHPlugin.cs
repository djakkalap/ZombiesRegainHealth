using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Smod2;
using Smod2.API;
using Smod2.Attributes;
using Smod2.Config;
using Smod2.EventHandlers;
using Smod2.Events;
using Smod2.Lang;
using Smod2.Piping;

using ZombiesRegainHealth.Events;

namespace ZombiesRegainHealth {
    [PluginDetails(
        author = "djakkalap",
        name = "ZombiesRegainHealth",
        description = "This plugin heals SCP-049-2 instances when they kill someone.",
        id = "djakkalap.zrhplugin",
        configPrefix = "zrh",
        version = "0.1",
        SmodMajor = 3,
        SmodMinor = 5,
        SmodRevision = 0
        )]

    public class ZRHPlugin : Plugin {
        public override void OnDisable() {
            Info(Details.name + " has been disabled.");
        }

        public override void OnEnable() {
            Info(Details.name + " has been enabled.");
        }

        // Register parts of the plugin.
        public override void Register() {
            AddEventHandler(typeof(IEventHandlerPlayerDie), new ZombieKillEvent(this));
        }
    }
}
