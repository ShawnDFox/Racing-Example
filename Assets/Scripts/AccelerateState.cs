using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateState : IaState
{

    //more like driving...

    private AICar thisCar;
    private Transform[] CPList;
    private int CCP;

    public void enter(AICar ai)
    {
        thisCar = ai;
        CPList = thisCar.Checkpoints;
        CCP = 0;
    }

    public void Execute()
    {
       
            thisCar.verticalInput = 1;
        
        thisCar.HandleMotor();
        driving();
        Debug.Log("accelerating");
    }

    private void driving()
    {
        Vector3 relativePos = CPList[CCP].position - thisCar.transform.position;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        Debug.Log(rotation +"Target "+ CCP);
        thisCar.horizontalInput = rotation.x;
    }

    public void exit()
    {
        throw new System.NotImplementedException();
    }

    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);
        if (other.tag == "CP")
        {
            if (CCP > CPList.Length)
            {
                CCP = 0;
            }
            else {
                CCP++;
            }
        }
    }
}
