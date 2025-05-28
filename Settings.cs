using BTD_Mod_Helper.Api.Data;
using BTD_Mod_Helper.Api.ModOptions;

namespace StatDisplay
{
    public class Settings : ModSettings
    {
        public static readonly ModSettingHotkey LogStatsHotkey = new(UnityEngine.KeyCode.Backslash)
        {
            description = "Log various ingame stats to the console."
        };
    }
}
