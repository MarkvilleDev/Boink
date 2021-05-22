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
    public int curScene;
    
    private void Start() {
        int scene = SceneManager.GetActiveScene().buildIndex;
        curScene = scene;
    }
    public void win()
    {
        fade.SetActive(true);
        animator.SetTrigger("win");
        Debug.Log("win");
        winCanvas.SetActive(true);
        usual.SetActive(false);
        saveController.GetComponent<Player>().winLevel(curScene - 3);
        saveController.GetComponent<Player>().SavePlayer();
    }
    public void lose() 
    {
        // curScene = SceneManager.GetActiveScene().buildIndex;
        // SceneManager.LoadScene(curScene);
        Time.timeScale = 0f;
        loseCanvas.SetActive(true);
        winCanvas.SetActive(false);
        usual.SetActive(false);
    }
    public void loadNext() 
    {   
        Debug.Log(curScene);
        SceneManager.LoadScene(curScene+1);
    }
    public void reset() 
    {
        SceneManager.LoadScene(curScene);
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
