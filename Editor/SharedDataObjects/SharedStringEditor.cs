using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace dev.jonasjohansson.Communication.SharedDataObjects {
    [CustomEditor(typeof(SharedStringSO))]
    [CanEditMultipleObjects]
    public class SharedStringEditor : Editor
    {
        SharedStringSO m_value;
        protected virtual void OnEnable()
        {
            m_value = this.serializedObject.targetObject as SharedStringSO;
        }
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            var newString = EditorGUILayout.TextField("Value", m_value.Value);
            if (EditorGUI.EndChangeCheck())
            {
                m_value.Value = newString;
            }
        }
    }
}