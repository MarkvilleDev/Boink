using System.Collections;
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
    public GameObject audioManager;
    // public AudioSource returntoMenu;
    public int curScene;
    
    private void Start() {
        int scene = SceneManager.GetActiveScene().buildIndex;
        curScene = scene;
    }
    public void win()
    {
        audioManager = GameObject.FindGameObjectWithTag("audiomanager");
        audioManager.GetComponent<buttonAudManager>().Playwin();
        winCanvas.SetActive(true);
        fade.SetActive(true);
        usual.SetActive(false);
        saveController.GetComponent<Player>().winLevel(curScene - 5);
        saveController.GetComponent<Player>().SavePlayer();
    }
    public void lose() 
    {
        // curScene = SceneManager.GetActiveScene().buildIndex;
        // SceneManager.LoadScene(curScene);
        Debug.Log("you lose");
        audioManager = GameObject.FindGameObjectWithTag("audiomanager");
        audioManager.GetComponent<buttonAudManager>().losegamesound();
        fade.SetActive(true);
        loseCanvas.SetActive(true);
        winCanvas.SetActive(false);
        usual.SetActive(false);
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
