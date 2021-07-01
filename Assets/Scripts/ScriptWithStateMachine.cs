using Vast.StateMachine;
using UnityEngine;

public class ScriptWithStateMachine : MonoBehaviour
{

    [SerializeField] public StateMachine sm;
    private State jmpState;

    // Start is called before the first frame update
    void Start()
    {
        jmpState = sm.AddState(new Jumping());
        if (sm.ContainsState(jmpState.Name))
        {
            sm.ChangeState(jmpState);
        }
    }

    // Update is called once per frame
    void Update()
    {
        sm.UpdateActiveState();
    }
}
