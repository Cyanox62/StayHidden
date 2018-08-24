using System;
using Smod2;
using Smod2.API;
using Smod2.EventHandlers;
using Smod2.Events;
using Smod2.Attributes;
using System.Collections.Generic;

namespace StayHidden
{
	[PluginDetails(
	author = "Cyanox",
	name = "StayHidden",
	description = "Keeps your tag hidden between rounds",
	id = "cyan.stayhidden",
	version = "0.1",
	SmodMajor = 3,
	SmodMinor = 0,
	SmodRevision = 0
	)]
	public class StayHidden : Plugin
    {
		public bool enabled = false;
		public string status = "";
		public List<string> TargetList = new List<string>();

		public override void OnDisable()
		{
		}

		public override void OnEnable()
		{

		}

		public override void Register()
		{
			this.AddEventHandlers(new EventHandler(this, this));
			this.AddCommand("stayhidden", new ToggleCommand(this, this));
		}
	}
}
