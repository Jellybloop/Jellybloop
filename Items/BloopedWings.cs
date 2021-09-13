using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;


namespace Bloopsmod.Items
{
    [AutoloadEquip(EquipType.Wings)]
    public class BloopedWings : ModItem
	{
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blooped Wings");
            Tooltip.SetDefault("flight and improvements to offense stats. Bloop made these so he can fly instead of hopping.");
        }

		public override void SetDefaults()
		{
			
			item.width = 22;
                        item.height = 20;
			item.value = 15000;
			item.rare = 2;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			 player.wingTimeMax = 680;
                         player.meleeDamage = 1.1f;
                         player.meleeCrit += 3;
                         player.rangedDamage = 1.1f;
                         player.rangedCrit += 3;
                         player.magicDamage = 1.1f;
                         player.magicCrit = +3;
                         player.manaCost = 0.8f;
                         player.statManaMax2 += 20;
                         player.minionDamage = 1.1f;
                         player.maxMinions += 1;
                   
                     
			
		}

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 4f;
			maxAscentMultiplier = 4f;
			constantAscend = 0.135f;
		}

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
                        speed = 11f;
			acceleration *= 3.0f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BloopedBar", 5);
                        recipe.AddIngredient(3470, 1);
                        recipe.AddIngredient(3471, 1);
                        recipe.AddIngredient(3468, 1);
                        recipe.AddIngredient(3469, 1);
                        recipe.AddIngredient(575, 200);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			}
			
		}
	
}