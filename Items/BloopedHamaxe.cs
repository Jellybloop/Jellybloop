using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
namespace Bloopsmod.Items
{
	public class BloopedHamaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Blooped Hamaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("same as the sword, weilding the Hamaxe can be difficult.");
		}

		public override void SetDefaults() 
		{
			item.damage = 320;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 16;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.axe = 200;
                        item.hammer = 400;                      
                        item.crit = 18;
                        
                       
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BloopedBar", 5);
                        recipe.AddIngredient(3552, 1);
                        recipe.AddIngredient(3523, 1);
                        recipe.AddIngredient(3524, 1);
                        recipe.AddIngredient(3522, 1);
                        recipe.AddIngredient(27, 100);
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