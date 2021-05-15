using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelchanger : MonoBehaviour
{
    public Animator animator;

    public void win()
    {
        animator.SetTrigger("win");
        Debug.Log("win");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
