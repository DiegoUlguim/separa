using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcionaMusica : MonoBehaviour
{
    public AudioSource sing;

    private void Start()
    {
        if (PlayerPrefs.GetInt("prefAudio") == 1)
        {
            sing.Play();
        }
    }

    public void AtivaDesativaMusica()
    {
        if (sing.isPlaying)
        {
            PlayerPrefs.SetInt("prefAudio", 0);
            sing.Pause();
        }
        else
        {
            PlayerPrefs.SetInt("prefAudio", 1);
            sing.Play();
        }
    }
}
