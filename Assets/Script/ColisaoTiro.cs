using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColisaoTiro : MonoBehaviour
{
    public GameObject lixeira;
    public GameObject funcaoGeral;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "barreira")
        {
            Debug.Log("lixeira: " + lixeira.name);
            Debug.Log("objeto: " + collision.gameObject.name);
            if (collision.gameObject == lixeira)
            {
                Debug.Log("ponto positivo");
                GameObject efeitoAcerto = GameObject.Find("MapaGeral/Game/Lixos/EfeitoAcerto");
                efeitoAcerto.transform.position = new Vector3(18.1f, lixeira.transform.position.y,0);
                efeitoAcerto.GetComponent<ParticleSystem>().Play();
                funcaoGeral.GetComponent<GameScript>().ContaPonto(1, Convert.ToInt32(this.name.Substring(4)));
                collision.gameObject.GetComponent<TrocaPosisaoLixeiras>().trocaPosisao();
            }
            else
            {
                Debug.Log("ponto negativo");
                funcaoGeral.GetComponent<GameScript>().ContaPonto(-1, Convert.ToInt32(this.name.Substring(4)));
            }
        }
        gameObject.GetComponent<TiroBehaviour>().speed = 0;
        gameObject.GetComponent<TiroBehaviour>().atira = false;
        gameObject.SetActive(false);
    }

}
