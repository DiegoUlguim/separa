using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string tela;
    public GameObject game;

    public void Transicao()
    {
        SceneManager.LoadScene(tela, LoadSceneMode.Single);
        Time.timeScale = 1f;
        Debug.Log("Transição tela: " + tela);
    }
    public void StartLevel()
    {
        SceneManager.LoadScene(tela, LoadSceneMode.Single);
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
        Debug.Log("Iniciar nivel: " + tela);
    }
}
