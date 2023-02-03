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
			Item.width = 30;
			Item.height = 30;
			Item.maxStack = 99;
			Item.value = 1000;
			Item.rare = 2;
		}
	}
}