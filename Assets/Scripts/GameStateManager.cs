using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;
using UnityEngine.Assertions;

public class GameStateManager : MonoBehaviour
{

    [SerializeField] private StateMachine stateMachine;
    private State inMenuState;

    // Note to self: Awake called before Start(), even if script it disabled.
    private void Awake()
    {
        stateMachine.OnStateChange += HandleStateChange;
    }

    private void OnDestroy()
    {
        stateMachine.OnStateChange -= HandleStateChange;
    }
   
    void Start()
    {
        // Set initial game state on Start()
        inMenuState = stateMachine.AddState(new GameState.InMainMenu());
        Assert.IsTrue(stateMachine.ContainsState(inMenuState));
        stateMachine.ChangeState(inMenuState);
        
    }

    private void HandleStateChange(State newState)
    {
        Debug.Log(this.name + " says, the state is now " + newState.Name);

        // TODO: Handle state changes, deligate to individual state handling objects maybe
        // TODO: Determine flow of control for this

    }
}
