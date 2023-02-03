using Terraria.ModLoader;

namespace Ottomania.Items.Materials
{
	public class RedPepper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Pepper");
			Tooltip.SetDefault("Fresh grinded red pepper flakes, very hot");
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