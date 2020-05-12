using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NoBossHealthScaling
{
    public class BossHealthScaling : GlobalNPC
    {
        public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale) {
            Main.expertMode = false;
			if (npc.type != 81) { // Corrupted Slime Dupe Fix
				npc.SetDefaults(npc.type);
			}
            Main.expertMode = true;
        }
    }
}
