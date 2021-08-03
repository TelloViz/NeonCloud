using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    public Button startButton;
    public Button testButton;
    public Label testText;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        startButton = root.Q<Button>("start-button");
        testButton = root.Q<Button>("test-button");
        testText = root.Q<Label>("test-text");

        startButton.clicked += StartButtonPressed;
        testButton.clicked += TestButtonPressed;
    }

    void StartButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }

    void TestButtonPressed()
    {
        testText.style.display = DisplayStyle.Flex;
    }
}
