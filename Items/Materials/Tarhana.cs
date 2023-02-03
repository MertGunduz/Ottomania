using Terraria.ModLoader;

namespace Ottomania.Items.Materials
{
	public class Tarhana : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tarhana");
			Tooltip.SetDefault("Freshly made, coming from a small village in middle anatolia region");
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