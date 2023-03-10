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
			Item.width = 30;
			Item.height = 30;
			Item.maxStack = 99;
			Item.value = 1000;
			Item.rare = 2;
		}
	}
}