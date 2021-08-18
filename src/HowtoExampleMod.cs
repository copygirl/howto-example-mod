using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

[assembly: ModInfo( "HowtoExample",
	Description = "An example mod using VS Code and .NET",
	Website     = "https://github.com/copygirl/howto-example-mod",
	Authors     = new []{ "copygirl" } )]

namespace HowtoExample
{
	public class HowtoExampleMod : ModSystem
	{
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
