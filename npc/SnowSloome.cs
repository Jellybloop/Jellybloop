using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bloopsmod.npc
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class SnowSloome : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Snow Sloome");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults() {
			npc.width = 10;
			npc.height = 10;
			npc.damage = 0;
			npc.defense = 6;
			npc.lifeMax = 5;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 0f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 7;
                        npc.friendly = true;
			
			animationType = NPCID.Zombie;
			
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo){
		return SpawnCondition.OverworldDaySnowCritter.Chance * 50.5f;

		}
}
}
