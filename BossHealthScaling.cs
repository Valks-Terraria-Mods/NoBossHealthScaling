using Terraria;
using Terraria.ModLoader;

namespace NoBossHealthScaling
{
    public class BossHealthScaling : GlobalNPC
    {
        public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale) {
            Main.expertMode = false;
            npc.SetDefaults(npc.type);
            Main.expertMode = true;
        }
    }
}
