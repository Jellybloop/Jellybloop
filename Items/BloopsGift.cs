using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bloopsmod.Items
{
	public class BloopsGift : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Bloops's Gift");
			Tooltip.SetDefault("bloop was to vanerable so he uses it to survive lethal blows!");
		}

		public override void SetDefaults() {
                       
			item.width = 28; 
			item.height = 24;
			item.accessory = true; // Makes this item an accessory.
			item.rare = 2; 
			item.defense = 50;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.lavaImmune = true;
			player.noFallDmg = true;
                        player.noKnockback = true;
                        player.breath = (player.breathMax -1);
                        player.endurance = 0.50f;
                        player.buffImmune[BuffID.Venom] = true;
                        player.buffImmune[BuffID.Poisoned] = true;
                        player.buffImmune[BuffID.Bleeding] = true;
                        player.buffImmune[BuffID.OnFire] = true;
                        player.buffImmune[BuffID.Darkness] = true;
                        player.buffImmune[BuffID.Blackout] = true;
                        player.buffImmune[BuffID.Silenced] = true;
                        player.buffImmune[BuffID.Cursed] = true;
                        player.buffImmune[BuffID.Confused] = true;
                        player.buffImmune[BuffID.Slow] = true;
                        player.buffImmune[BuffID.Weak] = true;
                        player.buffImmune[BuffID.BrokenArmor] = true;
                        player.buffImmune[BuffID.WitheredArmor] = true;
                        player.buffImmune[BuffID.WitheredWeapon] = true;
                        player.buffImmune[BuffID.CursedInferno] = true;
                        player.buffImmune[BuffID.Ichor] = true;
                        player.buffImmune[BuffID.Frostburn] = true;
                        player.buffImmune[BuffID.Chilled] = true;
                        player.buffImmune[BuffID.Frozen] = true;
                        player.buffImmune[BuffID.Webbed] = true;
                        player.buffImmune[BuffID.Stoned] = true;
                        player.buffImmune[BuffID.VortexDebuff] = true;
                        player.buffImmune[BuffID.Obstructed] = true;
                        player.buffImmune[BuffID.Electrified] = true;
                        player.buffImmune[BuffID.Rabies] = true;
                        player.buffImmune[BuffID.MoonLeech] = true;
                        player.buffImmune[BuffID.Dazed] = true;
                        player.buffImmune[BuffID.WindPushed] = true;
                        player.buffImmune[BuffID.OgreSpit] = true;
}
                       public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(mod, "BloopedBar", 5);
                        recipe.AddIngredient(1613, 1);
                        recipe.AddIngredient(938, 1);
                        recipe.AddIngredient(1253, 1);
                        recipe.AddIngredient(3110, 1);
                        recipe.AddIngredient(292, 30);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
