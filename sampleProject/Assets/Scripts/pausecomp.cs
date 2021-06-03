using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausecomp : MonoBehaviour {
    public GameObject pauseMenuUI;
    public GameObject usualButton;
    // public GameObject credits_Page;
    public AudioSource pausemenu;
    public GameObject audiomanager;
    public GameObject gameController;
    public GameObject winner;
    public GameObject healthCanvas;
    public GameObject mute;
    public GameObject unmute;

    // public void Setup() {
    //     // normal screen on, pause screen off
    //     usualButton.SetActive(true);
    //     pauseMenuUI.SetActive(false);
    //     credits_Page.SetActive(false);
    // }

    public void pausegame() {
        // usual off, pause on
        Debug.Log("paused");
        pauseMenuUI.SetActive(true);
        //audiomanager = GameObject.FindGameObjectWithTag("audiomanager");
        // audiomanager.GetComponent<buttonAudManager>().muting();
        usualButton.SetActive(false);
        gameController.SetActive(false);
        //winner.SetActive(false);
        //healthCanvas.SetActive(false);
        // credits_Page.SetActive(false);
        Time.timeScale = 0f;
    }
    public void resume() {
        Debug.Log("resumed");
        // if u press the back ig
        healthCanvas = GameObject.FindGameObjectWithTag("healthCanvas");
        winner = GameObject.FindGameObjectWithTag("Finish");
        pauseMenuUI.SetActive(false);
        usualButton.SetActive(true);
        gameController.SetActive(true);
        //winner.SetActive(true);
        //healthCanvas.SetActive(true);
        // credits_Page.SetActive(false);
        Time.timeScale = 1f;
    }
    // public void back_toPause(){
    //     pauseMenuUI.SetActive(true);
    //     audiomanager = GameObject.FindGameObjectWithTag("audiomanager");
    //     audiomanager.GetComponent<buttonAudManager>().muting();
    //     usualButton.SetActive(false);
    //     // credits_Page.SetActive(false);
    // }
}
