using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraObjeto : MonoBehaviour
{
    public float rateSapwn;
    private float currentRateSapwn;
    public int maxBloco;
    private int qLixo=0;
    private int qDemora=0;

    private int qLixoTeste = 0;

    void Update()
    {
        currentRateSapwn += Time.deltaTime;
        qLixoTeste = 0;
        for (int i = 1; i < 6; i++)
        {
            GameObject lixo = GameObject.Find("MapaGeral/Game/SpawnObjeto/sLixo" + i);
            
            if (lixo.activeSelf == true)
            {
                qLixoTeste += 1;
            }
        }
        if (qLixoTeste != qLixo)
        {
            qLixo = qLixoTeste;
            Debug.Log("erro na quantidade certo= " + qLixoTeste + " atual =" + qLixo);
        }
            

        if (currentRateSapwn > rateSapwn)
        {
            currentRateSapwn = 0;
            //Debug.Log(qLixo);
            if(qLixo == 5)
            {
                qDemora += 1;
                if (qDemora >= 5)
                {
                    GameObject game = GameObject.Find("MapaGeral/Game");
                    game.GetComponent<GameScript>().gameOver();
                }
            }
            else if (qLixo == 4)
            {
                if(qDemora>0)
                    qDemora -= 1;
                for (int i = 1; i < 5; i++)
                {
                    GameObject lixo = GameObject.Find("MapaGeral/Game/SpawnObjeto/sLixo" + i);
                    if (lixo.activeSelf == false)
                    {
                        Spawn(lixo);
                        break;
                    }
                }
            }
            else
            {
                if (qDemora > 0)
                    qDemora -= 1;
                string objeto = "sLixo" + Random.Range(1, 6);
                GameObject tpLixo = GameObject.Find("MapaGeral/Game/SpawnObjeto/" + objeto);

                //Debug.Log(objeto);
                while (tpLixo.activeSelf == true && qLixo < maxBloco)
                {
                    objeto = "sLixo" + Random.Range(1, 6);
                    tpLixo = GameObject.Find("MapaGeral/Game/SpawnObjeto/" + objeto);
                    //Debug.Log(objeto);
                }
                Spawn(tpLixo);
            }
        }

    }
    private void Spawn(GameObject lixo)
    {
        if(lixo.activeSelf == false)
        {
            lixo.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            lixo.SetActive(true);
            lixo.GetComponent<BlocoBehaviour>().speed = 2.5f;
            AtualizaQuantLixo(1);
        }
    }
    public void AtualizaQuantLixo(int quant)
    {
        qLixo += quant;
    }
    public void UpSpeed()
    {
        if(rateSapwn > 4)
            rateSapwn -= 0.5f;
        else if (rateSapwn > 3f)
            rateSapwn -= 0.4f;
        else if(rateSapwn > 1.5f)
            rateSapwn -= 0.3f;
        else if (rateSapwn > 1f)
            rateSapwn -= 0.2f;
        else if (rateSapwn > 0.4f)
            rateSapwn -= 0.1f;
    }

}

