using Smod2.API;
using Smod2.EventHandlers;
using Smod2.Events;

namespace ZombiesRegainHealth.Events {
    class ZombieKillEvent : IEventHandlerPlayerDie {
        private readonly ZRHPlugin plugin;

        // Add plugin to this instance.
        public ZombieKillEvent(ZRHPlugin plugin) => this.plugin = plugin;

        public void OnPlayerDie(PlayerDeathEvent ev) {
            if (ev.Killer.TeamRole.Role == Role.SCP_049_2)
            {
                Player killer = ev.Killer;
                int roleMaxHealth = killer.TeamRole.MaxHP;
                int killerHealth = killer.GetHealth();
                int healthRegen = plugin.GetConfigInt("zrh_health_regen");

                if (killerHealth != killer.TeamRole.MaxHP)
                {
                    // If the sum is greater than maxHealth, we just set it to the maximum.
                    if (killerHealth + healthRegen > roleMaxHealth)
                    {
                        killer.SetHealth(roleMaxHealth);
                    }
                    else
                    {
                        killer.AddHealth(healthRegen);
                    }
                }
            }
        }
    }
}
