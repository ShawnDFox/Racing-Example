using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AImixer : MonoBehaviour
{

    public AudioMixerSnapshot AIinactive;
    public AudioMixerSnapshot AIactive;
   

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("triggered " + other.GetComponentInParent<Rigidbody>().name);
        try
        {
            if (other.GetComponentInParent<Rigidbody>().name == "car 1203 yellow")
            {
                AIactive.TransitionTo(0.5f);
                ;
            }
        }
        catch(System.Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        try {

            if (other.GetComponentInParent<Rigidbody>().name == "car 1203 yellow")
            {
                AIinactive.TransitionTo(0.5f);
                
            }

        } catch (System.Exception e) { Debug.Log(e.Message); }
        
    }
}
