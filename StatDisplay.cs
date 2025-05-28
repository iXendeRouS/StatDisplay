using MelonLoader;
using BTD_Mod_Helper;
using StatDisplay;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using BTD_Mod_Helper.Extensions;
using System;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;

[assembly: MelonInfo(typeof(StatDisplay.StatDisplay), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace StatDisplay;

public class StatDisplay : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<StatDisplay>("StatDisplay loaded!");
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (InGame.instance == null || PopupScreen.instance.IsPopupActive() || !Settings.LogStatsHotkey.JustPressed()) return;

        try
        {
            var ingame = InGame.instance;

            ModHelper.Msg<StatDisplay>("Stats:");
            ModHelper.Msg<StatDisplay>($"Bloons:      {ingame.GetBloons().Count}");
            ModHelper.Msg<StatDisplay>($"Towers:      {ingame.GetTowers().Count}");
            ModHelper.Msg<StatDisplay>($"Projectiles: {ingame.GetProjectiles().Count}");
        } catch (Exception e)
        {
            ModHelper.Error<StatDisplay>(e);
        }
    }
}