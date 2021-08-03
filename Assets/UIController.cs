using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
