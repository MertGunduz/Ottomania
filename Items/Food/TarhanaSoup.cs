using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

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
	        item.maxStack = 20;
			item.rare = 1;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 2;
			item.UseSound = SoundID.Item3;
			item.consumable = true;
		}

        public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("ReadyForWinterBuff"), 360);
			return true;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Tarhana", 3);
            recipe.AddIngredient(null, "Mint", 2);
            recipe.AddIngredient(null, "TomatoPaste", 1);
            recipe.AddIngredient(null, "BlackPepper", 1);
            recipe.AddIngredient(null, "RedPepper", 1);
            recipe.AddIngredient(null, "Salt", 1);
			recipe.AddTile(TileID.CookingPot);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}