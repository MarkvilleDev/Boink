using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collide : MonoBehaviour
{
   public GameObject lvlchngscript;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DrawnWall"))
        {
            hit();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
            lvlchngscript.GetComponent<levelchanger>().win();
        }
    }

    private void hit()
    {
        Debug.Log("Ouch");
        GameObject.Destroy(GameObject.FindGameObjectWithTag("DrawnWall"));
    }

}