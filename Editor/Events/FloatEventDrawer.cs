using UnityEditor;
using UnityEngine;

namespace dev.jonasjohansson.Communication.Events
{
    [CustomPropertyDrawer(typeof(FloatEventSO), true)]
    public class FloatEventDrawer : PropertyDrawer
    {
        private int m_currentPickerWindow;
        private float m_testFloat = 0;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            var value = property.objectReferenceValue as FloatEventSO;
            if (value != null)
            {
                float totalWidth = position.width;
                float positionX = position.x;
                float ElementWidth = totalWidth * 0.8f;
                EditorGUI.PropertyField(new Rect(positionX, position.y, ElementWidth, position.height), property, label, true);
                positionX += ElementWidth;
                ElementWidth = totalWidth * 0.1f;
                m_testFloat = EditorGUI.FloatField(new Rect(positionX, position.y, ElementWidth, position.height), m_testFloat);
                positionX += ElementWidth;
                ElementWidth = totalWidth * 0.1f;
                if (GUI.Button(new Rect(positionX, position.y, ElementWidth, position.height), "Raise"))
                {
                    value.Raise(m_testFloat);
                }
                

                
            }
            else
            {
                EditorGUI.PropertyField(position, property, label, true);
            }

            EditorGUI.EndProperty();
        }
    }
}
