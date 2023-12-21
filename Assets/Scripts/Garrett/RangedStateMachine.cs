using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedStateMachine : MonoBehaviour
{

    public SationaryState Sationary;
    public LOSState LOS;
    public RangeHuntState RangeHunt;
    public FiringState Firing;
    public AIDeathState Death;
    // Start is called before the first frame update
    void Awake()
    {
        States.Add(Sationary);
        States.Add(LOS);
        States.Add(RangeHunt);
        States.Add(Firing);
        States.Add(Death);

        foreach(State state in States)
        {
            state.StateMachine = this;
        }
        ChangeState(nameof(Sationary));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
