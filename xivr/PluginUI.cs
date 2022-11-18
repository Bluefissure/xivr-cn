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

            ImGui.SetNextWindowSize(new Vector2(300, 350) * ImGuiHelpers.GlobalScale, ImGuiCond.FirstUseEver);
            ImGui.SetNextWindowSizeConstraints(new Vector2(300, 350) * ImGuiHelpers.GlobalScale, new Vector2(9999));
            if (ImGui.Begin("XIVR 设置", ref isVisible, ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoScrollWithMouse))
            {
                ImGui.BeginGroup();
                bool isEnabled = xivr.Configuration.isEnabled;
                if (ImGui.Checkbox("启用", ref isEnabled))
                {
                    xivr.Configuration.isEnabled = isEnabled;
                    xivr.Configuration.Save();
                }

                bool isAutoEnabled = xivr.Configuration.isAutoEnabled;
                if (ImGui.Checkbox("Auto Enable if steamvr is active", ref isAutoEnabled))
                {
                    xivr.Configuration.isAutoEnabled = isAutoEnabled;
                    xivr.Configuration.Save();
                }

                bool autoResize = xivr.Configuration.autoResize;
                if (ImGui.Checkbox("Auto Resize when activated", ref autoResize))
                {
                    xivr.Configuration.autoResize = autoResize;
                    xivr.Configuration.Save();
                }

                bool conLock = xivr.Configuration.conloc;
                if (ImGui.Checkbox("Enable first person controller locomotion", ref conLock))
                {
                    xivr.Configuration.conloc = conLock;
                    xivr.Configuration.Save();
                    xivr.Plugin.doUpdate = true;
                }

                bool motioncontrol = xivr.Configuration.motioncontrol;
                if (ImGui.Checkbox("Enable motion controllers", ref motioncontrol))
                {
                    xivr.Configuration.motioncontrol = motioncontrol;
                    xivr.Configuration.Save();
                    xivr.Plugin.doUpdate = true;
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
                if (ImGui.Checkbox("固定水平视角移动程度", ref horizontalLock))
                {
                    xivr.Configuration.horizontalLock = horizontalLock;
                    xivr.Configuration.Save();
                    xivr.Plugin.doUpdate = true;
                }

                bool verticalLock = xivr.Configuration.verticalLock;
                if (ImGui.Checkbox("固定垂直视角旋转程度", ref verticalLock))
                {
                    xivr.Configuration.verticalLock = verticalLock;
                    xivr.Configuration.Save();
                    xivr.Plugin.doUpdate = true;
                }

                bool horizonLock = xivr.Configuration.horizonLock;
                if (ImGui.Checkbox("保持头显与地平线高度一致", ref horizonLock))
                {
                    xivr.Configuration.horizonLock = horizonLock;
                    xivr.Configuration.Save();
                    xivr.Plugin.doUpdate = true;
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
