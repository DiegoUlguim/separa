using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Colisao : MonoBehaviour
{
    public GameObject Objeto;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Objeto)
        {
            GameObject lixo;
            bool pegaLixo = true;
            for (int i = 1; i < 6; i++)
            {    
                lixo = GameObject.Find("MapaGeral/Game/Lixos/Lixo" + i);

                if (lixo.activeSelf == true && lixo.GetComponent<TiroBehaviour>().atira==false)
                {
                    pegaLixo = false;
                    break;
                }
            }

            lixo = GameObject.Find("MapaGeral/Game/Lixos/" + this.name.Replace("s",""));
            if (pegaLixo == true) {
                GameObject spawnObjeto = GameObject.Find("MapaGeral/Game/SpawnObjeto");
                //spawnObjeto.GetComponent<GeraObjeto>().qLixo -= 1;
                spawnObjeto.GetComponent<GeraObjeto>().AtualizaQuantLixo(-1);
                lixo.SetActive(true);
                lixo.GetComponent<TiroBehaviour>().atira = false;
                lixo.GetComponent<BoxCollider2D>().enabled = false;
                this.gameObject.SetActive(false);
            }
        }
    }
}
