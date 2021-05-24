﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelchanger : MonoBehaviour
{
    public Animator animator;
    public GameObject winCanvas;
    public GameObject usual;
    public GameObject loseCanvas;
    public GameObject fade;
    public GameObject saveController;
    public AudioSource winSound;
    public GameObject losesound;
    // public AudioSource returntoMenu;
    public int curScene;
    
    private void Start() {
        int scene = SceneManager.GetActiveScene().buildIndex;
        curScene = scene;
    }
    public void win()
    {
        // winSound.Play();
        winCanvas.SetActive(true);
        fade.SetActive(true);
        usual.SetActive(false);
        saveController.GetComponent<Player>().winLevel(curScene - 5);
        saveController.GetComponent<Player>().SavePlayer();
        Time.timeScale = 0f;
    }
    public void lose() 
    {
        // curScene = SceneManager.GetActiveScene().buildIndex;
        // SceneManager.LoadScene(curScene)
        Debug.Log("u suck");
        // losesound = GameObject.FindGameObjectWithTag("audiomanager");
        // losesound.GetComponent<buttonAudManager>().losegamesound();
        fade.SetActive(true);
        loseCanvas.SetActive(true);
        winCanvas.SetActive(false);
        usual.SetActive(false);
        animator.SetTrigger("win");
        // Time.timeScale = 0f;
    }
    public void loadNext() 
    {
        animator.SetTrigger("win");
        Debug.Log("win");
        // Debug.Log(curScene);
        SceneManager.LoadScene(curScene+1);
    }
    public void reset() 
    {   
        curScene = SceneManager.GetActiveScene().buildIndex;
        fade.SetActive(true);
        animator.SetTrigger("win");
        Debug.Log("reset");
        SceneManager.LoadScene(curScene);
        Time.timeScale = 1f;
    }
    public void OnFadeComplete()
    {
        Debug.Log("move on");
        //SceneManager.LoadScene(curScene + 1);
    }
    public void disableCanvas()
    {
        fade.SetActive(false);
    }
    public void goHome() 
    {
        SceneManager.LoadScene(1);
    }
}
