using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICar : CarMovement
{
    public Transform[] Checkpoints; //checkpoints to guide the IA
    private IaState currentstate;//estado actual de la IA

    //maquina de estados para controlar la IA

    // Start is called before the first frame update
    void Start()
    {
        ChangeState(new IdleState());
    }

    // Update is called once per frame
    void Update()
    {
        currentstate.Execute();
    }

    public void ChangeState(IaState NewState) {
        if (currentstate != null) {
            currentstate.exit();
        }
        currentstate = NewState;
        currentstate.enter(this);
    }

    private void OnTriggerEnter(Collider collision)
    {
        currentstate.OnTriggerEnter(collision);
    }
}
