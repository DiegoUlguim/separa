using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public GameObject geraBloco;
    public GameObject txtPonto;
    public AudioSource newRecord;

    private int lixo1,lixo2,lixo3,lixo4,lixo5,totalAcerto,totalErro;

    private int pontoMaster=2;

    private void Update()
    {
        int pontoAtual = Convert.ToInt32(txtPonto.GetComponent<Text>().text);
        if(pontoAtual >= pontoMaster)
        {
            geraBloco.GetComponent<GeraObjeto>().UpSpeed();
            pontoMaster = pontoAtual + 2;
        }
    }

    public void ContaPonto(int ponto, int lixo)
    {
        int pontoAtual = Convert.ToInt32(txtPonto.GetComponent<Text>().text);
        txtPonto.GetComponent<Text>().text = Convert.ToString(pontoAtual + ponto);

        switch (lixo)
        {
            case 1:
                lixo1 ++;
                break;
            case 2:
                lixo2 ++;
                break;
            case 3:
                lixo3 ++;
                break;
            case 4:
                lixo4 ++;
                break;
            case 5:
                lixo5 ++;
                break;
        }
        if (ponto > 0)
            totalAcerto++;
        else
            totalErro++;

        if (Convert.ToInt32(txtPonto.GetComponent<Text>().text) < 0)
            gameOver();
    }

    public void gameOver()
    {
        Debug.Log("gameover");
        int score = Convert.ToInt32(txtPonto.GetComponent<Text>().text);

        Text textDadosReciclagem = GameObject.Find("MapaGeral/MenuRestart/Canvas/PainelButton/dadosReciclagem").GetComponent<Text>();
        if ((lixo2+lixo3+lixo4+lixo5)>0)
        {
            float calculoTotal = (lixo2 * 10) + (lixo3 * 35) + (lixo4 * 0.16f) + (lixo5 * 0.41f);
            textDadosReciclagem.text = "Parabéns! Você poupou o planeta em " + calculoTotal + " anos de decomposição.";
        }

        Text textDadosAcerto = GameObject.Find("MapaGeral/MenuRestart/Canvas/PainelButton/dadosAcerto").GetComponent<Text>();
        float percAcerto = totalAcerto + totalErro;
        if (percAcerto > 0)
        {
            percAcerto = ( totalAcerto / percAcerto )*100;
            textDadosAcerto.text = "Acerto de " + percAcerto + " %";
        }
        

        lixo1 = 0; //vidro
        lixo2 = 0; //metal
        lixo3 = 0; //plastico
        lixo4 = 0; //organico
        lixo5 = 0; //papel

        PauseMenu.pausaGame = true;
        if (score > PlayerPrefs.GetInt("recorde"))
        {
            Debug.Log("recorde = " + score);
            PlayerPrefs.SetInt("recorde", Convert.ToInt16(score));
            Debug.Log("recorde salvo = " + PlayerPrefs.GetInt("recorde").ToString());

            newRecord.Play();
        }
    }
}
