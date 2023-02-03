using Terraria.ModLoader;

namespace Ottomania.Items.Materials
{
	public class BlackPepper : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Pepper");
			Tooltip.SetDefault("Fresh grinded black pepper, might make you sneeze");
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