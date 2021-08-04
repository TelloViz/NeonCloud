using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class GameStateMachine : MonoBehaviour
{
    [SerializeField] private StateMachine stateMachine;
    private State inMenuState;

    // Note to self: Awake called before Start(), even if script it disabled.
    private void Awake()
    {
        
    }

    private void OnDestroy()
    {
        stateMachine.OnStateChange -= HandleStateChange;
    }

    void Start()
    {
        stateMachine.OnStateChange += HandleStateChange;
    }

    private void HandleStateChange(State newState)
    /// <summary>Hook into our underlying StateMachine field, This will get called on each state change</summary>
    {
        Debug.Log(this.name + " says, the state is now " + newState.Name);

        // TODO: Handle state changes, deligate to individual state handling objects maybe
        // TODO: Determine flow of control for this

    }
