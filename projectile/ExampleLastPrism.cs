
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace bloopsmod.projectile
{
	public class ExampleLastPrism : ModItem
	{
		// You can use a vanilla texture for your item by using the format: "Terraria/Item_<Item ID>".
		public override string Texture => "Terraria/Item_" + ItemID.LastPrism;
		public static Color OverrideColor = new Color(0, 300, 0);
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blooped Last Prism");
			Tooltip.SetDefault(@"bloop's very own enhanced last prism.");
		}

		public override void SetDefaults()
		{
			// Start by using CloneDefaults to clone all the basic item properties from the vanilla Last Prism.
			// For example, this copies sprite size, use style, sell price, and the item being a magic weapon.
			item.CloneDefaults(ItemID.LastPrism);
			item.mana = 35;
			item.damage = 1002;
			item.shoot = ModContent.ProjectileType<ExampleLastPrismHoldout>();
			item.shootSpeed = 30f;
                        item.crit = 22;
                        item.rare = 2;

			// Change the item's draw color so that it is visually distinct from the vanilla Last Prism.
			item.color = OverrideColor;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BloopedBar", 5);
                        recipe.AddIngredient(3541, 1);
                        recipe.AddIngredient(1295, 1);
                        recipe.AddIngredient(2882, 1);
                        recipe.AddIngredient(1260, 1);
                        recipe.AddIngredient(3457, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		// Because this weapon fires a holdout projectile, it needs to block usage if its projectile already exists.
		public override bool CanUseItem(Player player) => player.ownedProjectileCounts[ModContent.ProjectileType<ExampleLastPrismHoldout>()] <= 0;
	}
}
