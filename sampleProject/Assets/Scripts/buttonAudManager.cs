using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAudManager : MonoBehaviour
{
    public GameObject menuMusic;
    public GameObject mainStart;
    public GameObject backToMenuMusic;

    public void playStart ()
    {
        mainStart = GameObject.FindGameObjectWithTag("mainStartButton");
        mainStart.GetComponent<mainStartButton>().PlayMusic();
    }
    public void muteMenu()
    {
        menuMusic = GameObject.FindGameObjectWithTag("Music");
        menuMusic.GetComponent<musicClass>().StopMusic();
    }
    public void playMenu()
    {
        menuMusic = GameObject.FindGameObjectWithTag("Music");
        menuMusic.GetComponent<musicClass>().PlayMusic();
    }
    public void backToMenu()
    {
        backToMenuMusic = GameObject.FindGameObjectWithTag("backToMenu");
        backToMenuMusic.GetComponent<backToMenuButton>().PlayMusic();
    }

}