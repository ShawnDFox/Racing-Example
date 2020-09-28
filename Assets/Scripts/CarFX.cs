using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFX : MonoBehaviour
{
    private float velocity;
    public Rigidbody Rb;
    public AudioSource motorIdle;
    public AudioSource motorRun1;
    public AudioSource motorRun2;

   /*
    este codigo apunta a manejar tanto sonido como luces de los vehiculos
    */

    // Update is called once per frame
    void Update()
    {
        velocity = Rb.velocity.magnitude;//max velocity = 36 round to 40
        MotorSounds(velocity);
    }

    private void MotorSounds(float V)
    {
        //0-5 5-15 15-40  cambiar el pitch de los audios un funcion de la velocidad (sirtweakalot)
        if (V > 0 && V < 5)
        {
            if(motorRun1.isPlaying || motorRun2.isPlaying)
            {
                motorIdle.Play();
                motorRun1.Stop();
                motorRun2.Stop();
            }
            
            
            motorIdle.pitch = 1 + V / 5;
        }
        if (V > 5 && V < 15)
        {
            if (motorIdle.isPlaying || motorRun2.isPlaying)
            {
                motorIdle.Stop();
                motorRun1.Play();
                motorRun2.Stop();
            }


            motorRun1.pitch = 1 + V/10;
        }
        if (V > 15 && V < 40)
        {
            if (motorRun1.isPlaying )
            {
                motorRun1.Stop();
                motorRun2.Play();
            }
            
            
            motorRun2.pitch = 1+V/25;
        }
    }
}
