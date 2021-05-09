using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait : MonoBehaviour
{
    public float time = 6f;
    void Start()
    {
        StartCoroutine(load());
    }

    IEnumerator load()
    {
        yield return new WaitForSeconds(time);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
