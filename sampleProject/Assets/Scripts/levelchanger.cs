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
    public AudioSource winSound;
    public AudioSource losesound;
    public AudioSource returntoMenu;
    public int curScene;
    
    private void Start() {
        int scene = SceneManager.GetActiveScene().buildIndex;
        curScene = scene;
    }
    public void win()
    {
        winSound.Play();
        winCanvas.SetActive(true);
        fade.SetActive(true);
        usual.SetActive(false);
        saveController.GetComponent<Player>().winLevel(curScene - 3);
        saveController.GetComponent<Player>().SavePlayer();
    }
    public void lose() 
    {
        // curScene = SceneManager.GetActiveScene().buildIndex;
        // SceneManager.LoadScene(curScene);
        losesound.Play();
        fade.SetActive(true);
        loseCanvas.SetActive(true);
        winCanvas.SetActive(false);
        usual.SetActive(false);
    }
    public void loadNext() 
    {
        animator.SetTrigger("win");
        Debug.Log("win");
        Debug.Log(curScene);
        SceneManager.LoadScene(curScene+1);
    }
    public void reset() 
    {
        fade.SetActive(true);
        animator.SetTrigger("win");
        Debug.Log("win");
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
        returntoMenu.Play();
        wait();
        SceneManager.LoadScene(1);
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
    }
}
