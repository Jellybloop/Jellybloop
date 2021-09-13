
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Bloopsmod.npc
{
	public class BloopedBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults() {
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Cyan;
			item.expert = true;
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void OpenBossBag(Player player) {
		
			int choice = Main.rand.Next(7);
			if (choice == 0) {
				player.QuickSpawnItem(mod.ItemType("BloopedFragment"),50);
			

			}
			player.QuickSpawnItem(mod.ItemType("BloopedTotem"));
			
		}

		public override int BossBagNPC => ModContent.NPCType<npc.BloopedGaurdian>();
	}
}