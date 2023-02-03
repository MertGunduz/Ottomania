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
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.value = 1000;
			item.rare = 2;
		}
	}
}