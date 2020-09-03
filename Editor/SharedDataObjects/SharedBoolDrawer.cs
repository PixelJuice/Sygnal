using UnityEditor;
using UnityEngine;

namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    [CustomPropertyDrawer(typeof(SharedBoolSO), true)]
    public class SharedBoolDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            var value = property.objectReferenceValue as SharedBoolSO;
            if (value != null)
            {
                EditorGUI.BeginChangeCheck();
                float totalWidth = position.width;
                float positionX = position.x;
                float ElementWidth = totalWidth * 0.9f;
                EditorGUI.PropertyField(new Rect(positionX, position.y, ElementWidth, position.height), property, label, true);
                positionX += ElementWidth;
                ElementWidth = totalWidth * 0.1f;
                var newValue = EditorGUI.Toggle(new Rect(positionX, position.y, ElementWidth, position.height), value.Value);
                if (EditorGUI.EndChangeCheck())
                {
                    value.Value = newValue;
                }
            }
            else
            {
                EditorGUI.PropertyField(position, property, label, false);
            }
            EditorGUI.EndProperty();
        }
    }
}
