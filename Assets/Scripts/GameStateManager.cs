using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class GameStateManager : MonoBehaviour
{

    [SerializeField] private StateMachine stateMachine;
    private State inMenuState;
    private State playingState;

    // Start is called before the first frame update
    void Start()
    {
        inMenuState = stateMachine.AddState(new GameState.InMainMenu());

        if (stateMachine.ContainsState(inMenuState))
        {
            stateMachine.ChangeState(inMenuState);
        }
    }

    // Update is called once per frame
    void Update()
    {
        stateMachine.UpdateActiveState();
    }

    private void FixedUpdate()
    {
        stateMachine.FixedUpdateActiveState();
    }
}
