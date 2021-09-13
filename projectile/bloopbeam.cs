using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bloopsmod.projectile
{

public class bloopbeam : ModProjectile
{
public override void SetDefaults()
{

projectile.width = 1; //projectile width
projectile.height = 1; //projectile height
projectile.friendly = true; //make that the projectile will not damage you
projectile.melee = true; //
projectile.tileCollide = true; //make that the projectile will be destroed if it hits the terrain
projectile.penetrate = 30; //how many npc will penetrate
projectile.timeLeft = 180; //how many time this projectile has before disepire
projectile.light = 5.00f; // projectile light
projectile.extraUpdates = 1;
projectile.ignoreWater = true;
projectile.light = 5;

}
 public override void AI()
        {
            //Projectile appears at 4 ticks
            if(projectile.ai[0] > 4f)
            {
                for(int i = 0; i < 4; i++)
                {
                    int DustID = Dust.NewDust(projectile.position, projectile.width + 2, projectile.height + 2, 75, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 2f);
                    Main.dust[DustID].noGravity = true;
                    Main.dust[DustID].scale *= 1.75f;
                }
            }

            projectile.ai[0] += 1f;

{
             projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
    }
}
}