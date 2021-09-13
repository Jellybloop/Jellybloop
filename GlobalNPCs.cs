using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bloopsmod
{
    public class GlobalNPCs : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(30) == 0)
            {
                if (npc.type == NPCID.Parrot)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ChickenNugget"));
                     
                
               
}
}
}
}
}

