using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace bloopsmod.Items
{
	public class BloopedMegaGun : ModItem
	{
		public override void SetStaticDefaults(){
                  //    DisplayName.SetDefault("Blooped Mega Gun);
			Tooltip.SetDefault("bloop made this because weilding a sword can be hard without hands.");
		}

		public override void SetDefaults() {
			item.damage = 1700; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.ranged = true; // sets the damage type to ranged
			item.width = 40; // hitbox width of the item
			item.height = 40; // hitbox height of the item
			item.useTime = 1; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 1; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 50; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 10000; // how much the item sells for (measured in copper)
			item.rare = 2; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item11; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
		        item.shoot = mod.ProjectileType("bloopbullet"); //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 52f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Bullet; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(mod, "BloopedBar", 5);
                        recipe.AddIngredient(533, 1);
                        recipe.AddIngredient(1553, 1);
                        recipe.AddIngredient(1265, 1);
                        recipe.AddIngredient(197, 1);
                        recipe.AddIngredient(3475, 1);
                        recipe.AddIngredient(3456, 25);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

}
		}
