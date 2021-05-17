using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelchanger : MonoBehaviour
{
    public Animator animator;
    public GameObject winCanvas;
    public GameObject usual;
    public int curScene;
    
    private void Start() {
        int ind = SceneManager.GetActiveScene().buildIndex;
        curScene = ind;
    }
    public void win()
    {
        animator.SetTrigger("win");
        Debug.Log("win");
        winCanvas.SetActive(true);
        usual.SetActive(false);
    }
    public void loadNext() 
    {   
        Debug.Log(curScene);
        SceneManager.LoadScene(curScene+1);
    }
    public void reset() {
        SceneManager.LoadScene(curScene);
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
