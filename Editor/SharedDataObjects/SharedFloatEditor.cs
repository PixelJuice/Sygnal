using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;

namespace dev.jonasjohansson.Communication.SharedDataObjects {
    [CustomEditor(typeof(SharedFloatSO))]
    public class SharedFloatEditor : Editor
    {
        SharedFloatSO m_value;

        protected virtual void OnEnable()
        {
            m_value = this.serializedObject.targetObject as SharedFloatSO;
        }
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            var newfloat = EditorGUILayout.DelayedFloatField("Value", m_value.Value);
            if (EditorGUI.EndChangeCheck())
            {
                m_value.Value = newfloat;
            }
        }
    }
}