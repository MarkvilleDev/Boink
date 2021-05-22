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
        if (collision.gameObject.CompareTag("DrawnWall") || collision.gameObject.CompareTag("Wall"))
        {
            hit();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
            lvlchngscript.GetComponent<levelchanger>().win();
        }
    }
    public int generateRandom() {
        int index = Random.Range(0,7);
        return index;
    }
    private void hit()
    {
        Debug.Log(generateRandom());
        GameObject.Destroy(GameObject.FindGameObjectWithTag("DrawnWall"));
        int curIndex = generateRandom();
        // AudioSource curBounce = GetComponent<AudioSource>();
        // curBounce.clip = bounce[curIndex];
        // curBounce.Play();
        bounce[curIndex].Play();
    }

}