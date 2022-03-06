﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    public void StartLevel()
    {
        SceneManager.LoadScene("Arcade", LoadSceneMode.Single);
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
        Debug.Log("Start Game");
    }
    
}
