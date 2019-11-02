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

namespace ZombiesRegainHealth.Events {
    class DebugEvent : IEventHandlerDoorAccess {
        private readonly ZRHPlugin plugin;
        public DebugEvent(ZRHPlugin plugin) => this.plugin = plugin;

        // Just for testing, because I don't have anyone to test it with :(
        public void OnDoorAccess(PlayerDoorAccessEvent ev) {
            if (ev.Player.TeamRole.Role == Role.SCP_049_2)
            {
                Player killer = ev.Player;

                killer.AddHealth(plugin.GetConfigInt("zrh_healthregen"));
            }
        }
    }
}
