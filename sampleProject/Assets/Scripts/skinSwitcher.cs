using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinSwitcher : MonoBehaviour
{
    public GameObject[] prefab;
    public GameObject load;

    public void Start()
    {
        load.GetComponent<Player>().LoadPlayer();
        prefab = GameObject.FindGameObjectsWithTag("skins");
        Debug.Log("startinggg");
        for (int i = 0; i < prefab.Length; i++)
        {
            prefab[i].SetActive(false);
        }
        prefab[load.GetComponent<Player>().skin-1].SetActive(true);
    }
    public void skin_0()
    {
        load.GetComponent<Player>().skin = 0;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_1() {
        load.GetComponent<Player>().skin = 1;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin-1].SetActive(true);
    }
    public void skin_2()
    {
        load.GetComponent<Player>().skin = 2;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin-1].SetActive(true);
    }
    public void skin_3()
    {
        load.GetComponent<Player>().skin = 3;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin-1].SetActive(true);
    }
    public void skin_4()
    {
        load.GetComponent<Player>().skin = 4;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_5()
    {
        load.GetComponent<Player>().skin = 5;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_6()
    {
        load.GetComponent<Player>().skin = 6;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_7()
    {
        load.GetComponent<Player>().skin = 7;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_8()
    {
        load.GetComponent<Player>().skin = 8;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_9()
    {
        load.GetComponent<Player>().skin = 9;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_10()
    {
        load.GetComponent<Player>().skin = 10;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_11()
    {
        load.GetComponent<Player>().skin = 11;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_12()
    {
        load.GetComponent<Player>().skin = 12;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_13()
    {
        load.GetComponent<Player>().skin = 13;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_14()
    {
        load.GetComponent<Player>().skin = 14;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_15()
    {
        load.GetComponent<Player>().skin = 15;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_16()
    {
        load.GetComponent<Player>().skin = 16;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_17()
    {
        load.GetComponent<Player>().skin = 17;
        load.GetComponent<Player>().SavePlayer();
        prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
}
