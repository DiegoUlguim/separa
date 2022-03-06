using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeraTiro : MonoBehaviour
{
    public GameObject sing;

    public void Fire()
    {
        for (int i = 1; i < 6; i++)
        {
            GameObject Lixo = GameObject.Find("MapaGeral/Game/Lixos/Lixo" + i);

            if (Lixo.activeSelf == true)
            {
                Lixo.GetComponent<TiroBehaviour>().speed = -30;
                Lixo.GetComponent<TiroBehaviour>().atira = true;
                break;
            }
        }
    }

}
