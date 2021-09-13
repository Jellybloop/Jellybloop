using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bloopsmod.Items
{
	public class Nugget : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nugget"); // Automatic from .lang files
			Main.projFrames[projectile.type] = 4;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.ZephyrFish;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.zephyrfish = false; // Relic from aiType
			return true;
		}

			public override void AI() {
			Player player = Main.player[projectile.owner];

			#region Active check
			// This is the "active check", makes sure the minion is alive while the player is alive, and despawns if not
			if (player.dead || !player.active) {
				player.ClearBuff(ModContent.BuffType<Nuggy>());
			}
			if (player.HasBuff(ModContent.BuffType<Nuggy>())) {
				projectile.timeLeft = 2;
			}
			#endregion

			
		
		
	}
}
}
