using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;
using GameState;

public class GameStateMachine : MonoBehaviour
{
    // Serialized StateMachine allows for changing states in editor at run-time
    [SerializeField] private StateMachine stateMachine;

    private InMainMenu inMainMenuState;
    private Playing playingState;
    private InPauseMenu inPauseMenuState;

    [SerializeField] private GameObject inMainMenuController;
    [SerializeField] private GameObject PlayingController;
    [SerializeField] private GameObject inPauseMenuController;

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
        inMainMenuState = new InMainMenu();
        stateMachine.AddState(inMainMenuState);
        stateMachine.ChangeState(inMainMenuState);        


    }

    private void HandleStateChange(State newState)
    /// <summary>Hook into our underlying StateMachine field, This will get called on each state change</summary>
    {

        Debug.Log(this.name + " says, the state is now " + newState.Name);

        // TODO: Handle state changes, deligate to individual state handling objects maybe
        // TODO: Determine flow of control for this

        if(newState.Name == "InMainMenu")
        {
            inMainMenuController.SetActive(true);
            PlayingController.SetActive(false);
            inPauseMenuController.SetActive(false);
        }
        else if(newState.Name == "Playing")
        {
            inMainMenuController.SetActive(false);
            PlayingController.SetActive(true);
            inPauseMenuController.SetActive(false);
        }
        else if(newState.Name == "InPauseMenu")
        {
            inMainMenuController.SetActive(false);
            PlayingController.SetActive(false);
            inPauseMenuController.SetActive(true);
        }

    }
}
