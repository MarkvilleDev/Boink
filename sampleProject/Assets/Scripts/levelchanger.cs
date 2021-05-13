using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelchanger : MonoBehaviour
{
    public Animator animator;

    private int levelToLoad;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            fadeToLevel(SceneManager.GetActiveScene().buildIndex);
        }

    }

    public void fadeToLevel (int levelIndex) {
        levelToLoad = levelIndex+1;
        animator.SetTrigger("fadeOut");
    }
    public void OnFadeComplete ()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
