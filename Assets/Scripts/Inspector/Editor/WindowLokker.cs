using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

public class WindowLokker : EditorWindow
{
    [MenuItem("Window/Моё окошко")]

    public static WindowLokker ShowWindow()
    {
        WindowLokker window = GetWindow<WindowLokker>();

        window.titleContent = new GUIContent("Наше окно");

        window.minSize = new Vector2(300, 300);

        return window;
    }

    private void OnEnable()
    {
        TextField message = new TextField("Сообщение");

        ColorField color = new ColorField("Выбор цвета");

        color.showAlpha = false;

        Button send = new Button(() =>
        {
            Debug.Log("<color='#" + ColorUtility.ToHtmlStringRGB(color.value) + "'>" + message.value + "</color>");
        });

        send.text = "Отправить";

        rootVisualElement.Add(message);
        rootVisualElement.Add(color);
        rootVisualElement.Add(send);
    }
}
