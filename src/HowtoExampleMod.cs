using System;
using Vintagestory.API.Common;

namespace HowtoExample
{
	public class HowtoExampleMod : ModBase
	{
		public static HowtoExampleMod INSTANCE { get; private set; }
		
		public static ModInfo MOD_INFO { get; } = new ModInfo {
			Name        = "HowtoExample",
			Description = "An example mod using VS Code and .NET Core",
			Website     = "https://github.com/copygirl/VSModHowto",
			Author      = "copygirl",
		};
		
		public override ModInfo GetModInfo() { return MOD_INFO; }
		
		public override void Start(ICoreAPI api)
		{
			base.Start(api);
			INSTANCE = this;
			
			api.RegisterBlockBehavior(InstaTNTBehavior.NAME, typeof(InstaTNTBehavior));
		}
	}
}
