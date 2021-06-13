using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masteraudio : MonoBehaviour
{
    private AudioSource pausemenu;
    private AudioSource losesound;
    private AudioSource winsound;
    private AudioSource backToMenu;
    private AudioSource levelstart;
    private AudioSource mainStartbutton;
    private AudioSource playmenusound;
    private AudioSource[] bounce = new AudioSource[6];


    //private GameObject[] other;
    //private bool NotFirst = false;
    private GameObject savecontroller;

    //private void Awake()
    //{
    //    savecontroller = GameObject.FindGameObjectWithTag("savecontroller");
    //    other = GameObject.FindGameObjectsWithTag("audiomanager");
    //    foreach (GameObject oneOther in other)
    //    {
    //        if (oneOther.scene.buildIndex == -1)
    //        {
    //            NotFirst = true;
    //        }
    //    }

    //    if (NotFirst == true)
    //    {
    //        Destroy(gameObject);
    //    }

    //    DontDestroyOnLoad(transform.gameObject);
    //    pausemenu = GameObject.FindGameObjectWithTag("pausemenuopen").GetComponent<AudioSource>();
    //    losesound = GameObject.FindGameObjectWithTag("losesound").GetComponent<AudioSource>();
    //    savecontroller = GameObject.FindGameObjectWithTag("savecontroller");
    //    }

    public void pausemenusoundplay()
    {
        pausemenu = GameObject.FindGameObjectWithTag("pausemenuopen").GetComponent<AudioSource>();
        savecontroller = GameObject.FindGameObjectWithTag("savecontroller");
        savecontroller.GetComponent<Player>().LoadPlayer();
        if (pausemenu.isPlaying) stoppausemenusound();
        if (!savecontroller.GetComponent<Player>().ismuted)
        {
            pausemenu.Play();
            Debug.Log("PLAY PAUSE");
        }
    }

    public void stoppausemenusound()
    {
        pausemenu.Stop();
    }

    public void losesoundplay()
    {
        losesound = GameObject.FindGameObjectWithTag("losesound").GetComponent<AudioSource>();
        savecontroller = GameObject.FindGameObjectWithTag("savecontroller");
        savecontroller.GetComponent<Player>().LoadPlayer();
        if (losesound.isPlaying) stoplosesound();
        if (!savecontroller.GetComponent<Player>().ismuted)
        {
            losesound.Play();
        }
    }

    public void stoplosesound()
    {
        losesound.Stop();
    }

    public void winsoundplay()
    {
        winsound = GameObject.FindGameObjectWithTag("winsound").GetComponent<AudioSource>();
        savecontroller = GameObject.FindGameObjectWithTag("savecontroller");
        savecontroller.GetComponent<Player>().LoadPlayer();
        if (winsound.isPlaying) stopwinsound();
        if (!savecontroller.GetComponent<Player>().ismuted)
        {
            winsound.Play();
            Debug.Log ("WINSOUND");
        }
    }

    public void stopwinsound()
    {
        winsound.Stop();
    }

    public void mainstartplay()
    {
        mainStartbutton = GameObject.FindGameObjectWithTag("mainStartButton").GetComponent<AudioSource>();
        savecontroller = GameObject.FindGameObjectWithTag("savecontroller");
        savecontroller.GetComponent<Player>().LoadPlayer();
        if (mainStartbutton.isPlaying) stopmainstart();
        if (!savecontroller.GetComponent<Player>().ismuted)
        {
            mainStartbutton.Play();
            Debug.Log("START");
        }
    }

    public void stopmainstart()
    {
        mainStartbutton.Stop();
    }


    public void bouncePlay()
    {
        GameObject [] temp = GameObject.FindGameObjectsWithTag("bouncesound");
        for (int i = 0; i < bounce.Length; i++)
        {
            bounce[i] = temp[i].GetComponent<AudioSource>();
        }
        savecontroller = GameObject.FindGameObjectWithTag("savecontroller");
        savecontroller.GetComponent<Player>().LoadPlayer();
        int curIndex = generateRandom();

        if (!savecontroller.GetComponent<Player>().ismuted)
        {
            bounce[curIndex].Play();
        }
    }

    public void levelstartplay()
    {
        levelstart = GameObject.FindGameObjectWithTag("levelstart").GetComponent<AudioSource>();
        savecontroller = GameObject.FindGameObjectWithTag("savecontroller");
        savecontroller.GetComponent<Player>().LoadPlayer();
        if (levelstart.isPlaying)
        {
            levelstartstop();
        }

        if (!savecontroller.GetComponent<Player>().ismuted)
        {
            levelstart.Play();
            Debug.Log("LEVEL START");
        }
    }

    public void levelstartstop()
    {
        levelstart.Stop();
    }

    public void backToMenuPlay()
    {
        backToMenu = GameObject.FindGameObjectWithTag("backToMenu").GetComponent<AudioSource>();
        savecontroller = GameObject.FindGameObjectWithTag("savecontroller");
        savecontroller.GetComponent<Player>().LoadPlayer();
        if (backToMenu.isPlaying) backToMenuStop();
        if (!savecontroller.GetComponent<Player>().ismuted)
        {
            backToMenu.Play();
        }
    }
    public void backToMenuStop()
    {
        backToMenu.Stop();
    }

    public void playmenu()
    {
        playmenusound = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        savecontroller = GameObject.FindGameObjectWithTag("savecontroller");
        savecontroller.GetComponent<Player>().LoadPlayer();
        if (playmenusound.isPlaying) playmenustop();
        if (!savecontroller.GetComponent<Player>().ismuted)
        {
            playmenusound.mute = false;
        }
    }
    public void playmenustop()
    {
        playmenusound = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        playmenusound.mute=true;
    }


    public int generateRandom()
    {
        int index = Random.Range(0, 6);
        return index;
    }
}
