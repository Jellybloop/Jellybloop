using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bloopsmod.Items
{
	public class ChickenNugget : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName and Tooltip are automatically set from the .lang files, but below is how it is done normally.
			// DisplayName.SetDefault("Paper Airplane");
			// Tooltip.SetDefault("Summons a Paper Airplane to follow aimlessly behind you");
			DisplayName.SetDefault("Chicken nugget");
			Tooltip.SetDefault("spawns nugget.");
		}
	

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = ModContent.ProjectileType<Items.Nugget>();
			item.buffType = ModContent.BuffType<Items.Nuggy>();
                        
		}

		

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}