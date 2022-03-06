﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{ 

    public void LoadLevel()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        Time.timeScale = 1f;
        PauseMenu.pausaGame = true;
        Debug.Log("Start Game");
    }

}
