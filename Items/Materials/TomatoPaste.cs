using Terraria.ModLoader;

namespace Ottomania.Items.Materials
{
	public class TomatoPaste : ModItem
	{
			public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tomato Paste");
			Tooltip.SetDefault("A bowl of fresh tomato paste");
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