using Terraria.ModLoader;

namespace Ottomania.Items.Materials
{
	public class Mint : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mint");
			Tooltip.SetDefault("Fresh and strong-smelling mint leaves");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.value = 1000;
			item.rare = 2;
		}
	}
}