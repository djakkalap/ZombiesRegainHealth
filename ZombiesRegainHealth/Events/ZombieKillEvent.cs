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
    class ZombieKillEvent : IEventHandlerPlayerDie {
        private readonly ZRHPlugin plugin;

        public ZombieKillEvent(ZRHPlugin plugin) => this.plugin = plugin;

        public void OnPlayerDie(PlayerDeathEvent ev) {

            if (ev.Killer.TeamRole.Role == Role.SCP_049_2)
            {
                Player killer = ev.Killer;
                
                killer.AddHealth(plugin.GetConfigInt("zrh_health_regen"));
            }
        }
    }
}
