using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace HowtoExample
{
	public class HowtoExampleMod : ModBase
	{
		public static ModInfo MOD_INFO { get; } = new ModInfo {
			Name        = "HowtoExample",
			Description = "An example mod using VS Code and .NET Core",
			Website     = "https://github.com/copygirl/VSModHowto",
			Author      = "copygirl",
		};
		
		public override ModInfo GetModInfo() { return MOD_INFO; }
		
		public override void Start(ICoreAPI api)
		{
			api.RegisterBlockBehaviorClass(InstaTNTBehavior.NAME, typeof(InstaTNTBehavior));
		}
		
		public override void StartClientSide(ICoreClientAPI api)
		{
			
		}
		
		public override void StartServerSide(ICoreServerAPI api)
		{
			
		}
	}
}
