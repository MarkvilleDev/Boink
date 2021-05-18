using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collide : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DrawnWall"))
        {
            hit();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            win();
        }
    }

    private void hit()
    {
        Debug.Log("Ouch");
        GameObject.Destroy(GameObject.FindGameObjectWithTag("DrawnWall"));
    }
    private void win()
    {
        GameObject.FindGameObjectWithTag("Player").SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Debug.Log("WIN");
    }
}
