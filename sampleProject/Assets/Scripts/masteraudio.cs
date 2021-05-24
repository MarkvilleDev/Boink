using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masteraudio : MonoBehaviour
{
    private AudioSource pausemenu;
    private AudioSource losesound;
    private GameObject[] other;
    private bool NotFirst = false;
    public GameObject savecontroller;
    private void Awake()
    {
        savecontroller  = GameObject.FindGameObjectWithTag("savecontroller");
        other = GameObject.FindGameObjectsWithTag("masteraudio");
        foreach (GameObject oneOther in other)
        {
            if (oneOther.scene.buildIndex == -1)
            {
                NotFirst = true;
            }
        }

        if (NotFirst == true)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        pausemenu = GameObject.FindGameObjectWithTag("pausemenuopen").GetComponent<AudioSource>();
        losesound = GameObject.FindGameObjectWithTag("losesound").GetComponent<AudioSource>();
    }

    public void pausemenusoundplay()
    {
        if (pausemenu.isPlaying) stoppausemenusound();
        pausemenu.Play();
    }

    public void stoppausemenusound()
    {
        pausemenu.Stop();
    }
    public void losesoundplay() {
        savecontroller.GetComponent<Player>().LoadPlayer();
        if (losesound.isPlaying) stoplosesound();
            // losesound.Play();
        if (!savecontroller.GetComponent<Player>().ismuted) {
            losesound.Play();
        }
    }
    public void stoplosesound() {
        losesound.Stop();
    }
}
