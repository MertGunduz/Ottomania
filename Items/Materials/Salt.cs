using Terraria.ModLoader;

namespace Ottomania.Items.Materials
{
	public class Salt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Salt");
			Tooltip.SetDefault("Makes the food delicious, rich in iodine");
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