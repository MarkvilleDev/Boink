using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collide : MonoBehaviour
{
    public GameObject lvlchngscript;
    // the bounce sounds
    public AudioSource[] bounce = new AudioSource[6];
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
        else {
            int curIndex = generateRandom();
            Debug.Log(curIndex);
            bounce[curIndex].Play();
        }

    }
    public int generateRandom() {
        int index = Random.Range(0,6);
        return index;
    }
    private void hitDrawn()
    {
        GameObject.Destroy(GameObject.FindGameObjectWithTag("DrawnWall"));
        int curIndex = generateRandom();
        Debug.Log(curIndex);
        bounce[curIndex].Play();
    }

}