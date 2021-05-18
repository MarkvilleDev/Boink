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
    public int curScene;
    
    private void Start() {
        int scene = SceneManager.GetActiveScene().buildIndex;
        curScene = scene;
    }
    public void win()
    {
        animator.SetTrigger("win");
        Debug.Log("win");
        winCanvas.SetActive(true);
        usual.SetActive(false);
    }
    public void lose() 
    {
        SceneManager.LoadScene(curScene);
        // loseCanvas.SetActive(true);
        // winCanvas.SetActive(false);
        // usual.SetActive(false);
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
        SceneManager.LoadScene(curScene+1);
    }
}
