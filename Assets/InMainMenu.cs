using Vast.StateMachine;
using UnityEngine;

public class InMainMenu : State
{
    private const string DEFAULT_NAME = "MenuState";

    public InMainMenu(string name = DEFAULT_NAME)
    {
        Name = name;
        Debug.Log(name + " state created...");
    }

    public override void OnEnter() { }

    public override void OnExit() { }

    public override void Update() { }

    public override void FixedUpdate() { }

}
