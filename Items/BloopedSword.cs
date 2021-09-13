using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
namespace Bloopsmod.Items
{
	public class BloopedSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BloopedSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("the replica of bloop's sword. how did bloop weild this even though he has no arms.");
		}

		public override void SetDefaults() 
		{
			item.damage = 6500;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item60;
			item.autoReuse = true;
                        item.shoot = mod.ProjectileType("bloopbeam");
                        item.shootSpeed = 20;
                        item.crit = 18;
                  
                       
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BloopedBar", 5);
                        recipe.AddIngredient(757, 1);
                        recipe.AddIngredient(2880, 1);
                        recipe.AddIngredient(989, 1);
                        recipe.AddIngredient(723, 1);
                        recipe.AddIngredient(3458, 25);
                        recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			// Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
			// 60 frames = 1 second
			target.AddBuff(39, 6000);
}


    
		
	}
}