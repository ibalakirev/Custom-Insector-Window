using System.Reflection;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Sphere))]

public class MyEditor : Editor
{
    private const string RadiusField = "_radius";
    private const string SLiderValueLabel = "Radius";
    private const float MinSliderValue = 0.01f;
    private const float MaxSliderValue = 5f;

    public override void OnInspectorGUI()
    {
        Sphere sphere = (Sphere)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("�������� ������"))
        {
            Debug.Log("������ ������");

            sphere.TestFunction();
        }

        if (GUILayout.Button("������ ������"))
        {
            Debug.Log("������ ������");

            sphere.TestFunction();
        }

        GUILayout.EndHorizontal();

        GUILayout.Label("��������");

        FieldInfo radiusField = sphere.GetType().GetField(RadiusField, BindingFlags.Instance | BindingFlags.NonPublic);

        float radius = (float)radiusField.GetValue(sphere);

        radius = EditorGUILayout.Slider(SLiderValueLabel, radius, MinSliderValue, MaxSliderValue);

        radiusField.SetValue(sphere, radius);

        sphere.transform.localScale = Vector3.one * radius;
    }
}
