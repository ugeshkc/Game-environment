using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnSpace : MonoBehaviour
{
    public AudioSource audio1, audio2;

     void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audio1.Stop();
            audio2.Play();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            audio1.Play();
            audio2.Stop();
        }
        
    }
}