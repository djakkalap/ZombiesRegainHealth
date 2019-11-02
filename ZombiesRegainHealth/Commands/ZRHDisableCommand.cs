using Smod2.Commands;

namespace ZombiesRegainHealth.Commands {
    class ZRHDisableCommand : ICommandHandler {
        private readonly ZRHPlugin plugin;

        public ZRHDisableCommand(ZRHPlugin plugin) => this.plugin = plugin;

        public string GetCommandDescription() {
            return "Disables the ZombiesRegainHealth plugin.";
        }

        public string GetUsage() {
            return "ZRHDISABLE";
        }

        public string[] OnCall(ICommandSender sender, string[] args) {
            plugin.Info("Disabling " + plugin.Details.name + "...");
            plugin.PluginManager.DisablePlugin(plugin);

            return new string[] { GetUsage() + " called, disabling " + plugin.Details.name };
        }
    }
}
