using UnityEngine;
using UnityEditor;

namespace dev.jonasjohansson.Communication.Events
{
    [CustomEditor(typeof(TriggerEventSO))]
    [CanEditMultipleObjects]
    public class TriggerFloatEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            TriggerEventSO sharedFloat = target as TriggerEventSO;
            if (GUILayout.Button("Raise"))
            {
                sharedFloat.Raise();
            }
        }
    }
}