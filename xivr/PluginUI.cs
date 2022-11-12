using System;
using System.Numerics;
using Dalamud.Interface;
using ImGuiNET;

namespace xivr
{
    public static class PluginUI
    {
        public static bool isVisible = false;

        public static void Draw()
        {
            if (!isVisible)
                return;

            ImGui.SetNextWindowSize(new Vector2(200, 270) * ImGuiHelpers.GlobalScale, ImGuiCond.FirstUseEver);
            ImGui.SetNextWindowSizeConstraints(new Vector2(200, 270) * ImGuiHelpers.GlobalScale, new Vector2(9999));
            if (ImGui.Begin("Configuration", ref isVisible, ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoScrollWithMouse))
            {
                ImGui.BeginGroup();
                bool vrEnabled = xivr.Configuration.isEnabled;
                if (ImGui.Checkbox("启用", ref vrEnabled))
                {
                    xivr.Configuration.isEnabled = vrEnabled;
                    xivr.Configuration.Save();
                }

                bool vrAutoEnabled = xivr.Configuration.isAutoEnabled;
                if (ImGui.Checkbox("若SteamVR可用自动启用", ref vrAutoEnabled))
                {
                    xivr.Configuration.isAutoEnabled = vrAutoEnabled;
                    xivr.Configuration.Save();
                }

                bool forceFloatingScreen = xivr.Configuration.forceFloatingScreen;
                if (ImGui.Checkbox("强制悬浮屏幕", ref forceFloatingScreen))
                {
                    xivr.Configuration.forceFloatingScreen = forceFloatingScreen;
                    xivr.Configuration.Save();
                }

                bool forceFloatingInCutscene = xivr.Configuration.forceFloatingInCutscene;
                if (ImGui.Checkbox("强制过场动画中悬浮屏幕", ref forceFloatingInCutscene))
                {
                    xivr.Configuration.forceFloatingInCutscene = forceFloatingInCutscene;
                    xivr.Configuration.Save();
                }

                bool horizontalLock = xivr.Configuration.horizontalLock;
                if (ImGui.Checkbox("水平自动贴合旋转", ref horizontalLock))
                {
                    xivr.Configuration.horizontalLock = horizontalLock;
                    xivr.Configuration.Save();
                }

                bool verticalLock = xivr.Configuration.verticalLock;
                if (ImGui.Checkbox("垂直自动贴合旋转", ref verticalLock))
                {
                    xivr.Configuration.verticalLock = verticalLock;
                    xivr.Configuration.Save();
                }

                bool horizonlLock = xivr.Configuration.horizonLock;
                if (ImGui.Checkbox("保持头显与水平线高度一致", ref horizonlLock))
                {
                    xivr.Configuration.horizonLock = horizonlLock;
                    xivr.Configuration.Save();
                }

                if (ImGui.Button("重新定位中间点"))
                {
                    xivr.Configuration.runRecenter = false;
                    xivr.Configuration.Save();
                    xivr.Configuration.runRecenter = true;
                }


                ImGui.End();
            }
        }
    }
}
