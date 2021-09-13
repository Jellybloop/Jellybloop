using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bloopsmod.npc
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class CrimSloome : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("CrimSloome");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults() {
			npc.width = 10;
			npc.height = 10;
			npc.damage = 1;
			npc.defense = 6;
			npc.lifeMax = 10;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 5f;
			npc.aiStyle = 26;
                       
			
			animationType = NPCID.Zombie;
			
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.Crimson.Chance * 0.5f;
		}
}
}