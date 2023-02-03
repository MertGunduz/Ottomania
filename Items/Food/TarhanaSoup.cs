using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Ottomania.Buffs;
using Ottomania.Items.Materials;

namespace Ottomania.Items.Food
{
	public class TarhanaSoup : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tarhana Soup");
			Tooltip.SetDefault(
            "A typical ottoman dish!\n" +
            "A good meal for harsh winters\n"
            );
		}

		public override void SetDefaults()
		{
            Item.width = 30;
			Item.height = 26;
	        Item.maxStack = 20;
			Item.rare = 1;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 2;
			Item.UseSound = SoundID.Item3;
			Item.consumable = true;
		}

        public override bool? UseItem(Player player)
		{
            player.AddBuff(BuffType<ReadyForWinterBuff>(), 36000, true);
			return true;
		}

        public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ItemType<Tarhana>(), 1)
				.AddIngredient(ItemType<Mint>(), 3)
				.AddIngredient(ItemType<TomatoPaste>(), 1)
				.AddIngredient(ItemType<BlackPepper>(), 3)
				.AddIngredient(ItemType<RedPepper>(), 1)
				.AddIngredient(ItemType<Salt>(), 3)
				.AddTile(TileID.CookingPots)
				.Register();
		}
    }
}