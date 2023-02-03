using Terraria.ModLoader;

namespace Ottomania.Items.Materials
{
	public class BlackPepper : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.value = 1000;
			item.rare = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Pepper");
			Tooltip.SetDefault("Fresh grinded black pepper, might make you sneeze");
		}
	}
}