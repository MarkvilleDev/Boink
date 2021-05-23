using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutemanager : MonoBehaviour
{
    private bool muted;
    public GameObject soundonicon;
    public GameObject soundofficon;

    public void mutepressed() 
    {
        muted = true;
        AudioListener.pause = muted;
        soundonicon.SetActive(false);
        soundofficon.SetActive(true);
    }
    public void muteunpressed() 
    {
        muted = false;
        AudioListener.pause = muted;
        soundonicon.SetActive(true);
        soundofficon.SetActive(false);
    }
}
