using HarmonyLib;

using KMod;

using PeterHan.PLib.Options;

namespace InfiniteSourceSink
{
	public class Mod : UserMod2
	{
		public override void OnLoad(Harmony harmony)
		{
			POptions opt = new POptions();
			opt.RegisterOptions(this, typeof(ModSettings));

			base.OnLoad(harmony);
		}
	}
}