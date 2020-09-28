using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IaState
{
    private AICar thisCar;

    public void Execute()
    {
        Debug.Log("Idling");
        this.thisCar.ChangeState(new AccelerateState());
    }

    public void enter(AICar ai)
    {
        thisCar = ai;
        thisCar.IsAi = true;
        Debug.Log("AI controls " + thisCar.name);
    }

    public void exit()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
    }
}
