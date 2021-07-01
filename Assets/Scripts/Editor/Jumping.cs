using Vast.StateMachine;
using UnityEngine;

public class Jumping : State {
    private const string DEFAULT_NAME = "Jumping";

    public Jumping(string name = DEFAULT_NAME) {
        Name = name;
        Debug.Log(name + " state created...");
    }

    public override void OnEnter() { }

    public override void OnExit() { }

    public override void Update() { Debug.Log("Jumping Like Mad"); }

    public override void FixedUpdate() { }

}
