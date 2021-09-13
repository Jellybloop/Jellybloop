using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
namespace Bloopsmod.Items
{
	public class BloopedTotem : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BloopedTotem"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("heals the player by 50 without cooldown or consuming it.");
		}

		public override void SetDefaults() 
		{
		
			
			item.width = 50;
			item.height = 50;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = 4;
			
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.healLife += 50;
                   
                       
		}

		



}

    
		
	}
