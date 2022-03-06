using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlocoBehaviour : MonoBehaviour
{
    public float speed;
    public GameObject bloco;

    public float inactive;

    void Update()
    {
        if (speed>0)
            bloco.transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;

        if (bloco.transform.position.x < inactive)
        {
            speed = 0;
        }        
        
    }
    
}
