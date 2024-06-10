using System;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(MyRanger))]

public class RangerDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        MyRanger myRanger = attribute as MyRanger;

        if (property.propertyType == SerializedPropertyType.Float)
        {
            EditorGUI.Slider(position, property, myRanger._min, myRanger._max, label);
        }
        else if (property.propertyType == SerializedPropertyType.Integer)
        {
            EditorGUI.IntSlider(position, property, Convert.ToInt32(myRanger._min),
                Convert.ToInt32(myRanger._max), "Размер");
        }
        else
        {
            EditorGUI.LabelField(position, label.text, "Используйте int или float");
        }
    }
}
