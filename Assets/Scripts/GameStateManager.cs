using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

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
    // Start is called before the first frame update
    void Start()
    {
        
        inMenuState = stateMachine.AddState(new GameState.InMainMenu());
        playingState = stateMachine.AddState(new GameState.Playing());

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

    private void HandleStateChange(State newState)
    {
        Debug.Log("You are subscribed mate!, the state is now " + newState.Name);
    }
}
