using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace dev.jonasjohansson.Communication.Events {
    [CustomEditor(typeof(FloatEventSO))]
    [CanEditMultipleObjects]
    public class SharedFloatEditor : Editor
    {
        private float m_testValue;
        public override void OnInspectorGUI()
        {
            FloatEventSO sharedFloat = target as FloatEventSO;
            m_testValue = EditorGUILayout.FloatField("Value", m_testValue);
            if (GUILayout.Button("Raise"))
            {
                sharedFloat.Raise(m_testValue);
            }
        }
    }
}