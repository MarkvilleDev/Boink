using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausecomp : MonoBehaviour {
    public GameObject pauseMenuUI;
    public GameObject usualButton;
    public GameObject credits_Page;
    public AudioSource pausemenu;
    // public void Setup() {
    //     // normal screen on, pause screen off
    //     usualButton.SetActive(true);
    //     pauseMenuUI.SetActive(false);
    //     credits_Page.SetActive(false);
    // }
    public void pausegame() {
        // usual off, pause on
        pauseMenuUI.SetActive(true);
        usualButton.SetActive(false);
        credits_Page.SetActive(false);
        Time.timeScale = 0f;
    }
    public void resume() {
        // if u press the back ig
        pauseMenuUI.SetActive(false);
        usualButton.SetActive(true);
        credits_Page.SetActive(false);
        Time.timeScale = 1f;
    }
    public void back_toPause(){
        pauseMenuUI.SetActive(true);
        usualButton.SetActive(false);
        credits_Page.SetActive(false);
    }
    public void privacyPolicy() {
        // add another canvas for this later
    }
    // public void credits(){
    //     // add another canvas for credits
    //     usualButton.SetActive(false);
    //     credits_Page.SetActive(true);
    //     pauseMenuUI.SetActive(false);
    // }
    public void about() {
        // add something for about as well 
    }
}
