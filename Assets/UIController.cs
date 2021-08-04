using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    public Button startButton;
    public Button exitButton;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        startButton = root.Q<Button>("button_start");
        exitButton = root.Q<Button>("button_exit");

        startButton.clicked += StartButtonPressed;
        exitButton.clicked += ExitButtonPressed;
    }

    void StartButtonPressed()
    {
        // TODO Transition to play state
        Debug.Log("Main Menu Start Pressed");
    }

    // TODO remove test button when no longer needed for testing
    void ExitButtonPressed()
    {
        Debug.Log("Main Menu Exit was pressed");
    }
}
