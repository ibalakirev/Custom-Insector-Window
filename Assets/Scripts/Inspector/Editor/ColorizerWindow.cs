using UnityEditor;
using UnityEngine;

public class ColorizerWindow : EditorWindow
{
    private Color _color = Color.white;

    [MenuItem("Window/Colorizer")]

    private static void ShowWindow()
    {
        GetWindow<ColorizerWindow>("Colorizer");
    }

    private void OnGUI()
    {
        _color = EditorGUILayout.ColorField("Color", _color);

        if (GUILayout.Button("ColorizerButton"))
        {
            Colorize();
        }
    }

    private void Colorize()
    {
        foreach (GameObject go in Selection.gameObjects)
        {
            Renderer renderer = go.GetComponent<Renderer>();

            if (renderer != null)
            {
                Material material = new(renderer.sharedMaterial)
                {
                    color = _color
                };

                renderer.sharedMaterial = material;
            }
        }
    }
}
