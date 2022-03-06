using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaPosisaoLixeiras : MonoBehaviour
{
    Vector3[] POSICAO = new Vector3[5];

    private void Start()
    {
        POSICAO[0] = new Vector3(19.7f, 4);
        POSICAO[1] = new Vector3(19.7f, 0.57875f);
        POSICAO[2] = new Vector3(19.7f, -2.8425f);
        POSICAO[3] = new Vector3(19.7f, -6.2637f);
        POSICAO[4] = new Vector3(19.7f, -9.685f);
    }

    public void trocaPosisao()
    {
        GameObject textTutorial = GameObject.Find("MapaGeral/MenuAux/CanvasTutorial");
        textTutorial.SetActive(false);

        int[] idLixeira = new int[5];
        int idAtual;
        int quant=0;
        bool adiciona; 

        while(quant < 5) 
        {
            adiciona = true;
            idAtual = Random.Range(1, 6);
            for (int x = 0; x < idLixeira.Length; x++)
            {
                if (idLixeira[x] == idAtual)
                    adiciona=false;
            }

            if (adiciona == true)
            {
                idLixeira[quant] = idAtual;
                quant++;
            }
        }

        for (int i = 0; i < idLixeira.Length; i++)
        {
            GameObject objeto = GameObject.Find("MapaGeral/Game/Lixeiras/Lixeira"+idLixeira[i]);
            objeto.transform.position = POSICAO[i];
        }

    }


}
