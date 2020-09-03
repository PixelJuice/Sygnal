using UnityEditor;
using UnityEngine;

namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    [CustomPropertyDrawer(typeof(SharedStringSO), true)]
    public class SharedStringDrawer : PropertyDrawer
    {
        int m_currentPickerWindow;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            var value = property.objectReferenceValue as SharedStringSO;
            if (value != null)
            {
                EditorGUI.BeginChangeCheck();
                float totalWidth = position.width;
                float positionX = position.x;
                float ElementWidth = totalWidth * 0.7f;
                EditorGUI.PropertyField(new Rect(positionX, position.y, ElementWidth, position.height), property, label, true);
                positionX += ElementWidth;
                ElementWidth = totalWidth * 0.3f;
                var newValue = EditorGUI.TextField(new Rect(positionX, position.y, ElementWidth, position.height), value.Value);
                if (EditorGUI.EndChangeCheck())
                {
                    value.Value = newValue;
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
