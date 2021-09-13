using Terraria;
using Terraria.ModLoader;

namespace bloopsmod.Items
{
	public class Nuggy : ModBuff
	{
		public override void SetDefaults()
		{
			// DisplayName and Description are automatically set from the .lang files, but below is how it is done normally.
			// DisplayName.SetDefault("Nuggy");
			// Description.SetDefault("\"follows you around!\"");
			Description.SetDefault("\"nuggy.\"");
			DisplayName.SetDefault("nuggy");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
            
			bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("Nugget")] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("Nugget"), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}