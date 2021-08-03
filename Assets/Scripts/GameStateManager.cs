using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;
using UnityEngine.Assertions;

public class GameStateManager : MonoBehaviour
{

    [SerializeField] private StateMachine stateMachine;
    private State inMenuState;
    private State playingState;

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

    // Update is called once per frame
    void Update()
    {
        stateMachine.UpdateActiveState();
    }

    private void FixedUpdate()
    {
        stateMachine.FixedUpdateActiveState();
    }

    private void HandleStateChange(State newState)
    {
        Debug.Log(this.name + " says, the state is now " + newState.Name);

        // TODO: Handle state changes

    }
}
