using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bloopsmod.npc
{
    public class GreenInferno : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Green Inferno");
            Tooltip.SetDefault("Summons the accidental Bioweapon not consumable. only accepts the eclipse");
            ItemID.Sets.ItemNoGravity[item.type] = true;
     
        }

        public override void SetDefaults()
        {
            item.width = 54;
            item.height = 54;
            item.rare = 3;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = 4;
            item.UseSound = SoundID.Item44;
            item.noUseGraphic = true;
            item.maxStack = 1;
            item.consumable = false;
        }

           public override bool CanUseItem(Player player)
        {
            if (!NPC.AnyNPCs(mod.NPCType("BloopedGaurdian")))
            
            {
                NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("BloopedGaurdian"));
                Main.PlaySound(SoundID.Roar, player.position, 0);
               
                return true;
                return NPC.downedMoonlord;
            }
            return false;
        }
                        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3601, 1);
                        recipe.AddIngredient(560, 1);
                        recipe.AddIngredient(2767 , 1);
                        recipe.AddIngredient(1011 , 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
}
}
}