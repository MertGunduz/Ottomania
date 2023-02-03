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
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.value = 1000;
			item.rare = 2;
		}
	}
}