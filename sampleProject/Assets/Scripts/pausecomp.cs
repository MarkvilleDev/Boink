using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausecomp : MonoBehaviour
{
    // public static bool paused = false; 
    public GameObject pauseMenuUI;
    // void Setup() {
    //     pauseMenuUI.SetActive(true);
    // }
    // Update is called once per frame
    // void Update(){
    //     pauseMenuUI.SetActive(false);
    //     Time.timeScale = 1f;
    //     paused = false;
    // }
    // public void pause() {
    //     pauseMenuUI.SetActive(true);
    //     Time.timeScale = 0f;
    //     paused = true;
    // }
    public void resume() {
        // if u press the back ig
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void privacyPolicy() {

    }
    public void credits(){

    }
    public void about() {

    }
}
