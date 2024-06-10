using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

public class WindowLokker : EditorWindow
{
    [MenuItem("Window/�� ������")]

    public static WindowLokker ShowWindow()
    {
        WindowLokker window = GetWindow<WindowLokker>();

        window.titleContent = new GUIContent("���� ����");

        window.minSize = new Vector2(300, 300);

        return window;
    }

    private void OnEnable()
    {
        TextField message = new TextField("���������");

        ColorField color = new ColorField("����� �����");

        color.showAlpha = false;

        Button send = new Button(() =>
        {
            Debug.Log("<color='#" + ColorUtility.ToHtmlStringRGB(color.value) + "'>" + message.value + "</color>");
        });

        send.text = "���������";

        rootVisualElement.Add(message);
        rootVisualElement.Add(color);
        rootVisualElement.Add(send);
    }
}
