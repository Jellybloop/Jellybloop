using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bloopsmod.npc
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class HallowSloome : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("HallowSloome");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults() {
			npc.width = 10;
			npc.height = 10;
			npc.damage = 40;
			npc.defense = 12;
			npc.lifeMax = 180;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 5f;
			npc.aiStyle = 26;
                        animationType = NPCID.Zombie;
			
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo){
		return SpawnCondition.OverworldHallow.Chance * 0.1;
		}
}
}
