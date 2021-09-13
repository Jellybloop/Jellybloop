
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Bloopsmod.npc
{
public class BloopedGaurdian : ModNPC
{
int projectileTimer = 0;

public override void SetDefaults()
{
npc.aiStyle = 90;
aiType = 521;
npc.lifeMax = 1000000;
npc.damage = 200;
npc.defense = 0;
npc.knockBackResist = -1f;
npc.width = 250;
npc.height = 250;
animationType = 48;
Main.npcFrameCount[npc.type] = 4;
npc.value = Item.buyPrice(1, 40, 75, 45);
npc.npcSlots = 50f;
npc.boss = true;
npc.lavaImmune = true;
npc.noGravity = true;
npc.noTileCollide = true;
npc.HitSound = SoundID.NPCHit44;
npc.DeathSound = SoundID.NPCDeath59;
npc.buffImmune[20] = true;
npc.buffImmune[39] = true;
npc.buffImmune[47] = true;
npc.buffImmune[69] = true;
music = MusicID.LunarBoss;
npc.netAlways = true;
npc.buffImmune[BuffID.Confused] = true;
}
public override void OnHitPlayer(Player player, int damage, bool crit) {
			
				player.AddBuff(BuffID.WitheredArmor, 1200, true);
                player.AddBuff(BuffID.Ichor, 1200, true);
                 player.AddBuff(BuffID.CursedInferno, 600 , true);
                 player.AddBuff(BuffID.MoonLeech, 20000 , true);
                  
                }
   public override void NPCLoot() {
        {
            if (Main.rand.Next(1) == 0)
            {
            Item.NewItem(npc.getRect(), mod.ItemType("BloopedFragment"),50);
              if (Main.expertMode) {
				Item.NewItem(npc.getRect(), mod.ItemType("BloopedBag"),1);
                {
                    
                     }}}}}

public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.damage = 250;
            npc.lifeMax = (int)(1200000 * bossLifeScale); 
           }
            
            public override void AI()
  
  {
   Lighting.AddLight(npc.position, new Vector3(0, 5555555,0 ));
        {
            Player player = Main.player[npc.target];
              if  (player.dead)
                {
                    npc.noGravity = true;
                        }
            projectileTimer++;
            if (projectileTimer == 60) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 26f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 80) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 100) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 2f, 10, 3, ProjectileID.EyeFire);
            }

            if (projectileTimer == 210) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 4f, 20, 3, ProjectileID.EyeFire);
            }

            if (projectileTimer == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 8f, 30, 3, ProjectileID.EyeFire);
            }

             if (projectileTimer == 230) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.EyeFire);
            }

            if (projectileTimer == 240) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.EyeFire);
            }

            if (projectileTimer == 250) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.EyeFire);
            }

           
            if (projectileTimer == 360) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 26f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 380) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 400) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 490) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 4f, 80, 3, ProjectileID.CultistBossLightningOrb);
            }
            
            if (projectileTimer == 560) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 4f, 80, 3, ProjectileID.CultistBossLightningOrb);
            }
             if (projectileTimer == 630) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 4f, 80, 3, ProjectileID.CultistBossLightningOrb);
            }
             if (projectileTimer == 680) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 26f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 700) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 720) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }
             if (projectileTimer == 800) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 50, 3, ProjectileID.CultistBossIceMist);
            }
             if (projectileTimer == 820) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 50, 3, ProjectileID.CultistBossIceMist);
            }
             if (projectileTimer == 840) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 50, 3, ProjectileID.CultistBossIceMist);
            }
             if (projectileTimer == 860) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 50, 3, ProjectileID.CultistBossIceMist);
            }
             if (projectileTimer == 880) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 50, 3, ProjectileID.CultistBossIceMist);
            }
             if (projectileTimer == 900) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 50, 3, ProjectileID.CultistBossIceMist);
            }
              if (projectileTimer == 900) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 50, 3, ProjectileID.CultistBossIceMist);
            }
             if (projectileTimer == 920) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 50, 3, ProjectileID.CultistBossIceMist);
            }
             if (projectileTimer == 980) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 26f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 1000) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 1020) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }
             if (projectileTimer == 1090) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1110) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1130) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
              if (projectileTimer == 1150) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1170) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1190) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1210) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1230) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1250) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
              if (projectileTimer == 1270) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1290) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1310) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1330) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1350) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1370) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
              if (projectileTimer == 1390) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1410) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1430) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1450) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1470) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1490) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
              if (projectileTimer == 1510) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1530) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1550) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 3f, 40, 3, ProjectileID.FlamingScythe);
            }
             if (projectileTimer == 1590) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 26f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 1610) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 1630) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }
             if (projectileTimer == 1690) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
              if (projectileTimer == 1720) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1730) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
              if (projectileTimer == 1740) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1750) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1760) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
                  if (projectileTimer == 1770) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1780) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1790) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1800) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1810) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1820) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
                  if (projectileTimer == 1830) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1840) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1850) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
              if (projectileTimer == 1860) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1870) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1880) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1890) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1900) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
              if (projectileTimer == 1910) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1920) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1930) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
              if (projectileTimer == 1940) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1950) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1960) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1970) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 1980) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
              if (projectileTimer == 1990) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 2000) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 2010) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 50, 3, ProjectileID.PaladinsHammerHostile);
            }
             if (projectileTimer == 2080) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 26f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 2100) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 2120) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 32f, 30, 3, ProjectileID.CursedFlameHostile);
            }
              if (projectileTimer == 2151) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2152) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2153) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2154) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2155) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2156) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2157) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2158) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2159) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2160) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2161) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2162) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2163) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2164) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2165) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2166) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2167) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2168) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2169) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2170) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2171) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2172) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2173) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2174) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
              if (projectileTimer == 2175) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2176) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2177) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2178) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2179) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2181) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2182) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2183) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2184) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2185) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2186) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2187) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2188) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2189) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2190) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2191) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2192) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2193) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2194) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2195) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2196) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2197) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2198) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
              if (projectileTimer == 2199) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2201) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2202) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2203) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2204) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2205) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2206) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2207) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2208) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2209) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2210) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2211) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2212) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2213) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2214) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2215) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2216) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2217) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2218) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2219) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2221) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
              if (projectileTimer == 2222) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2223) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2224) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2225) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2226) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2227) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2228) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2229) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2230) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2231) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2232) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2233) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2234) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2235) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2236) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2237) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2238) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2239) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2240) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2241) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2242) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2243) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2244) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2245) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
             if (projectileTimer == 2246) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2247) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2248) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2249) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2250) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2251) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2252) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2253) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2254) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2255) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2256) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2257) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2258) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2259) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2260) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2261) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2262) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2263) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2264) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                 if (projectileTimer == 2265) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2267) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2268) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2269) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2270) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2271) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
                if (projectileTimer == 2272) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2273) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2274) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
               if (projectileTimer == 2275) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }

            if (projectileTimer == 2276) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.PhantasmalEye);
            }
              if (projectileTimer == 2300) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 2320) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 2340) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.CursedFlameHostile);
            }
             if (projectileTimer == 2440) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2450) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2460) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2470) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2480) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2490) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2500) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2510) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2510) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2520) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2530) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2540) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2550) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2560) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2570) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2580) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2590) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
               if (projectileTimer == 2600) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2610) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2620) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2630) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2640) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2650) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2660) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2670) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2680) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2690) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2700) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2710) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2720) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2730) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2740) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2750) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
              if (projectileTimer == 2760) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 16f, 40, 3, ProjectileID.CultistBossFireBall);
            }
               if (projectileTimer == 2800) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.CursedFlameHostile);
            }

            if (projectileTimer == 2820) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.CursedFlameHostile);
            }
            if (projectileTimer == 2840) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 22f, 30, 3, ProjectileID.CursedFlameHostile);
            }
             if (projectileTimer == 2900) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 2920) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
            if (projectileTimer == 2930) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 2940) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 2950) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 2960) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
            if (projectileTimer == 2970) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 2980) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 2990) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3000) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
            if (projectileTimer == 3010) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3020) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3030) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3040) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
            if (projectileTimer == 3050) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3060) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
               if (projectileTimer == 3070) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3080) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
            if (projectileTimer == 3090) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3100) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3110) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3120) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
            if (projectileTimer == 3130) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3140) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3150) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3160) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
            if (projectileTimer == 3170) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3190) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
            if (projectileTimer == 3210) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 6f, 60, 3, ProjectileID.FrostWave);
            }
              if (projectileTimer == 3220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
            {
                SpawnProjectile(player, 12f, 60, 3, ProjectileID.FrostWave);
            }
            if(projectileTimer > 3200) // max case
            {
                projectileTimer = 0;
            }
        }
        void SpawnProjectile(Player player, float projectileSpeed, int damage, float knockBack, int type)
        {
            Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound

     

            Vector2 velocity = Vector2.Normalize(player.MountedCenter - npc.Center) * projectileSpeed; // We get a correct velocity towards the player.

            Projectile.NewProjectile(npc.Center, velocity, type, damage, knockBack, Main.myPlayer);

         }
        
       
        
         
        
    }
}}



		   
	












  
              