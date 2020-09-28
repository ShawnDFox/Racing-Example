using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IaState
{
    void Execute();
    void enter(AICar ai);
    void OnTriggerEnter(Collider other);
    void exit();

}
