using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bloopsmod.npc
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class VortexSloome : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Vortex Slooome");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults() {
			npc.width = 10;
			npc.height = 10;
			npc.damage = 70;
			npc.defense = 22;
			npc.lifeMax = 480;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 50f;
			npc.aiStyle = 26;
                        animationType = NPCID.Zombie;
			npc.knockBackResist = -1;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo){
		return SpawnCondition.VortexTower.Chance * 0.1f;

		}

public override void NPCLoot()
{
	Item.NewItem(npc.getRect(), ItemID.FragmentVortex, 1);
}
}
}