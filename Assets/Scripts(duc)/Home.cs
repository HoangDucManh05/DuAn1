using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    private VisualElement homeElement;
    // Start is called before the first frame update
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        homeElement = root.Q<VisualElement>("home");
        homeElement.style.display = DisplayStyle.Flex;
        Button Play = root.Q<Button>("play");
        Play.RegisterCallback<ClickEvent>(playgame);
        Button Exit = root.Q<Button>("exit");
        Exit.RegisterCallback<ClickEvent>(exit);
    }
    private void playgame(ClickEvent cke)
    {
        SceneManager.LoadScene("Map1(duc)");
    }
    private void exit(ClickEvent cke)
    {
        SceneManager.LoadScene("");
    }
}
