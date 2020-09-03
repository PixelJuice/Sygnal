using UnityEditor;
using UnityEngine;

namespace dev.jonasjohansson.Communication.Events
{
    [CustomPropertyDrawer(typeof(TriggerEventSO), true)]
    public class TriggerEventDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            var value = property.objectReferenceValue as TriggerEventSO;
            if (value != null)
            {
                float totalWidth = position.width;
                float positionX = position.x;
                float ElementWidth = totalWidth * 0.9f;
                EditorGUI.PropertyField(new Rect(positionX, position.y, ElementWidth, position.height), property, label, true);
                positionX += ElementWidth;
                ElementWidth = totalWidth * 0.1f;
                if (GUI.Button(new Rect(positionX, position.y, ElementWidth, position.height), "Raise"))
                {
                    value.Raise();
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
