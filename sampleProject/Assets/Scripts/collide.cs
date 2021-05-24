using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collide : MonoBehaviour
{
    public GameObject lvlchngscript;
    public GameObject audiomanager;

    // the bounce sounds
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DrawnWall"))
        {
            hitDrawn();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
            lvlchngscript.GetComponent<levelchanger>().win();
        }
        else
        {
            audiomanager = GameObject.FindGameObjectWithTag("audiomanager");
            audiomanager.GetComponent<buttonAudManager>().bounce();
        }

    }
    private void hitDrawn()
    {
        GameObject.Destroy(GameObject.FindGameObjectWithTag("DrawnWall"));


    }

}