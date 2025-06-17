using System;
using UnityEditor;
using UnityEditor.Build.Profile;
using UnityEngine;

namespace KuaiShouSDK
{
    [InitializeOnLoad]
    public static class KuaiShouSubTargetManager
    {
        static KuaiShouSubTargetManager()
        {
            MiniGameSubplatformManager.RegisterSubplatform(new KuaiShouSubplatformInterface());
        }
    }
    
    internal class KuaiShouSubplatformInterface : MiniGameSubplatformInterface
    {
        public override string GetSubplatformName()
        {
            return "KuaiShou:快手小游戏";
        }

        public override MiniGameSettings GetSubplatformSettings()
        {
            return new KuaiShouMiniGameSettings(new KuaiShouMiniGameSettingsEditor());
        }

        public override BuildMiniGameError Build(BuildProfile profile)
        {
            throw new NotImplementedException();
        }
        
    }
}
