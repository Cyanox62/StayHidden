using System;
using Smod2;
using Smod2.Commands;
using Smod2.API;
using Smod2.EventHandlers;
using Smod2.Events;
using System.Collections.Generic;
using System.Threading;

namespace StayHidden
{
	class ToggleCommand : ICommandHandler
	{
		private Plugin plugin;
		StayHidden sh;

		public ToggleCommand(Plugin plugin, StayHidden shc)
		{
			this.plugin = plugin;
			sh = shc;
		}

		public string GetCommandDescription()
		{
			return "Keeps your tag hidden between rounds.";
		}

		public string GetUsage()
		{
			return "STAYHIDDEN";
		}

		public string[] OnCall(ICommandSender sender, string[] args)
		{
			if (sender is Player player)
			{
				if (!sh.TargetList.Contains(player.SteamId))
				{
					plugin.Info(player.SteamId);
					sh.TargetList.Add(player.SteamId);
					sh.status = "StayHidden enabled for " + player.Name + ".";
					plugin.Info("StayHidden enabled for " + player.Name + ".");
					player.HideTag(true);
				}

				else if (sh.TargetList.Contains(player.SteamId))
				{
					plugin.Info("Remove");
					sh.TargetList.Remove(player.SteamId);
					sh.status = "StayHidden disabled for " + player.Name + ".";
					plugin.Info("StayHidden disabled for " + player.Name + ".");
					player.HideTag(false);
				}
			}

			return new string[] { sh.status };
		}
	}
}
