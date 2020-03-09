using StardewValley;
using StardewValley.Events;
using System.Reflection;

namespace CustomiseChildBedroom
{
    class Patch
    {
        public static bool PreventPregnancy(QuestionEvent __instance, int ___whichQuestion)
        {
            //If it's a 2 it's a barn animal, and that's ok
            if (___whichQuestion != 2)
            {
                if (!ModEntry.Config.GetCurrentFarm().GetFarmer(Game1.player.Name).ShowCrib)
                {
                    ModEntry.Log(Translation.GetString("effect.didwork"), StardewModdingAPI.LogLevel.Debug);
                    return false;
                }
            }
            return true;
        }
    }
}
