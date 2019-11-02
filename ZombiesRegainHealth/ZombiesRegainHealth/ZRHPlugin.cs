using Smod2;
using Smod2.Attributes;
using Smod2.Config;
using Smod2.EventHandlers;
using ZombiesRegainHealth.Commands;
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
            AddConfig(new ConfigSetting("zrh_health_regen", 15, true, "This integer determines how much HP the zombies should regenerate."));
            AddConfig(new ConfigSetting("zrh_disable", false, true, "Determines whether to disable the plugin."));

            AddCommand("zrhdisable", new ZRHDisableCommand(this));

            AddEventHandler(typeof(IEventHandlerPlayerDie), new ZombieKillEvent(this));
        }
    }
}
