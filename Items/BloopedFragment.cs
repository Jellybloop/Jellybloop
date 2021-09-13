using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
namespace Bloopsmod.Items
{
	public class BloopedFragment : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BloopedFragment"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("a fragment of bloop's version of Aruic tesla.");
                         ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void SetDefaults() 
		{
			
			item.width = 40;
			item.height = 40;
			item.value = 10000;
			item.rare = 2;
			item.maxStack = 999;
                        
                       

}
public override void PostUpdate() {
			Lighting.AddLight(item.Center, Color.Green.ToVector3() * 0.55f * Main.essScale);

    
		
	}
}}