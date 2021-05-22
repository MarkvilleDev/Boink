using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menusettings : MonoBehaviour
{
    public GameObject creditsscreeen;
    public GameObject aboutscreen;
    public GameObject privacypolicy;
    public GameObject main;

    public void credits() 
    {
        creditsscreeen.SetActive(true);
        main.SetActive(false);
        // aboutscreen.SetActive(false);
        // privacypolicy.SetActive(false);
    }
    public void backtomain()
    {
        main.SetActive(true);
        creditsscreeen.SetActive(false);
    }
}
