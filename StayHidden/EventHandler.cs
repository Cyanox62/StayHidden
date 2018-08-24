using System;
using Smod2;
using Smod2.API;
using Smod2.EventHandlers;
using Smod2.Events;
using System.Collections.Generic;

namespace StayHidden
{
	class EventHandler : IEventHandlerRoundStart, IEventHandlerRoundEnd, IEventHandlerPlayerJoin
	{
		private Plugin plugin;
		StayHidden sh;

		public EventHandler(Plugin plugin, StayHidden shc)
		{
			this.plugin = plugin;
			sh = shc;
		}

		public void OnRoundEnd(RoundEndEvent ev)
		{

		}

		public void OnRoundStart(RoundStartEvent ev)
		{

		}

		public void OnPlayerJoin(PlayerJoinEvent ev)
		{
			if (sh.TargetList.Contains(ev.Player.SteamId))
			{
				ev.Player.HideTag(true);
			}
		}
	}
}
