using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonAudManager : MonoBehaviour
{
    public GameObject menuMusic;
    public GameObject backToMenuMusic;
    public GameObject[] bouncesounds;
    public GameObject winsound;
    public GameObject losesound;
    public GameObject menusound;
    public GameObject levelstart;
    public GameObject masteraudioobject;
    public GameObject savecontroller;
    public GameObject mute;
    public GameObject unmute;

    public void Start()
    {
        Debug.Log("find menu");
        if (SceneManager.GetActiveScene().buildIndex >= 5) PlaylevelStart();
        savecontroller = GameObject.FindGameObjectWithTag("savecontroller");
        mute = GameObject.FindGameObjectWithTag("mute");
        unmute = GameObject.FindGameObjectWithTag("unmute");
        playMenu();
        if (SceneManager.GetActiveScene().buildIndex <5 ) {
            muting();
        }
    }
    public void muteMenu()
    {
        masteraudioobject = GameObject.FindGameObjectWithTag("audiomanager");
        masteraudioobject.GetComponent<masteraudio>().playmenustop();
    }
    public void playMenu()
    {
        masteraudioobject = GameObject.FindGameObjectWithTag("audiomanager");
        masteraudioobject.GetComponent<masteraudio>().playmenu();
    }
    public void backToMenu()
    {
        masteraudioobject = GameObject.FindGameObjectWithTag("audiomanager");
        masteraudioobject.GetComponent<masteraudio>().mainstartplay();
    }
    public void pausemenusound()
    {
        masteraudioobject = GameObject.FindGameObjectWithTag("audiomanager");
        masteraudioobject.GetComponent<masteraudio>().pausemenusoundplay();
    }
    public void losegamesound()
    {
        masteraudioobject = GameObject.FindGameObjectWithTag("audiomanager");
        masteraudioobject.GetComponent<masteraudio>().losesoundplay();
    }
    public void bounce()
    {
        masteraudioobject = GameObject.FindGameObjectWithTag("audiomanager");
        masteraudioobject.GetComponent<masteraudio>().bouncePlay();
    }
    public void Playwin()
    {
        masteraudioobject = GameObject.FindGameObjectWithTag("audiomanager");
        masteraudioobject.GetComponent<masteraudio>().winsoundplay();
    }
    public void PlaylevelStart()
    {
        masteraudioobject = GameObject.FindGameObjectWithTag("audiomanager");
        masteraudioobject.GetComponent<masteraudio>().levelstartplay();
    }
    public void mainStartButton()
    {
        masteraudioobject = GameObject.FindGameObjectWithTag("audiomanager");
        masteraudioobject.GetComponent<masteraudio>().mainstartplay();
    }
    public void muting ()
    {
        if (SceneManager.GetActiveScene().buildIndex >= 5)
        {
            if (GameObject.Find("pausemenu").transform.Find("Mute_soundon").gameObject != null) mute = GameObject.Find("pausemenu").transform.Find("Mute_soundon").gameObject;
            if (GameObject.Find("pausemenu").transform.Find("Mute_soundoff").gameObject != null) unmute = GameObject.Find("pausemenu").transform.Find("Mute_soundoff").gameObject;
        }
        if (savecontroller.GetComponent<Player>().ismuted)
        {
            muteMenu();
            if (mute != null)
            {
                mute.SetActive(false);
                Debug.Log("mute");
            }
            Debug.Log("transition");
            if (unmute != null)
            {
                unmute.SetActive(true);
                Debug.Log("unmute");
            }
        }
        else
        {
            playMenu();
            if (mute != null) mute.SetActive(true);
            if (unmute!=null) unmute.SetActive(false);
        }
    }

}