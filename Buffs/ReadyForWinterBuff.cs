using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ottomania.Buffs
{
	public class ReadyForWinterBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ready For Winter");
			Description.SetDefault("Melee power increased and immunity increased");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetDamage(DamageClass.Melee) += 0.35f;
			player.GetCritChance(DamageClass.Melee) += 5.5f;
			player.moveSpeed += 0.25f;

            player.buffImmune[44] = true;
            player.buffImmune[46] = true;
            player.buffImmune[47] = true;
		}
	}
}