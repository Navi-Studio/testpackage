using UnityEditor;
using UnityEditor.Build.Profile;
using UnityEngine;

namespace KuaiShouSDK
{
    internal class KuaiShouMiniGameSettingsEditor : MiniGameSettingsEditor
    {
        public virtual void OnMiniGameSettingsIMGUI(SerializedObject serializedObject, SerializedProperty miniGameProperty)
        {
            EditorGUILayout.LabelField("KuaiShouMiniGameSettingsEditor");
        }
    }
}
