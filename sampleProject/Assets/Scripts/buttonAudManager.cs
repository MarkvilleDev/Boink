using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAudManager : MonoBehaviour
{
    public GameObject menuMusic;
    public GameObject mainStart;
    public GameObject backToMenuMusic;
    public GameObject[] bouncesounds;
    public GameObject winsound;
    public GameObject losesound;
    public GameObject menusound;
    public GameObject levelstart;
    public GameObject masteraudioobject;
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
    public void pausemenusound() 
    {
        masteraudioobject = GameObject.FindGameObjectWithTag("masteraudio");
        masteraudioobject.GetComponent<masteraudio>().pausemenusoundplay();
    }
    public void losegamesound ()
    {
        masteraudioobject = GameObject.FindGameObjectWithTag("masteraudio");
        masteraudioobject.GetComponent<masteraudio>().losesoundplay();
    }
}