using Terraria;
using Terraria.ModLoader;

namespace Ottomania.Buffs
{
	public class ReadyForWinterBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Ready For Winter");
			Description.SetDefault("Melee power increased and immunity increased");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.meleeDamage += 0.35f;
			player.meleeCrit += 3.5f;
			player.moveSpeed += 0.25f;

            player.buffImmune[44] = true;
            player.buffImmune[46] = true;
            player.buffImmune[47] = true;
		}
	}
}