using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class skinSwitcher : MonoBehaviour
{
    public GameObject[] prefab;
    public GameObject[] selectedSkin;
    public GameObject load;

    public void Start()
    {
        load.GetComponent<Player>().LoadPlayer();
        selectedSkin = GameObject.FindGameObjectsWithTag("selectedSkin").OrderBy(go=>go.name).ToArray();
        if (selectedSkin.Length > 0) {
            for (int i = 0; i < selectedSkin.Length; i++)
            {
                selectedSkin[i].SetActive(false);
            }
            selectedSkin[load.GetComponent<Player>().skin].SetActive(true);
        }
        Debug.Log("startinggg");

        prefab = GameObject.FindGameObjectsWithTag("skins").OrderBy(go => go.name).ToArray();
        for (int i = 0; i < prefab.Length; i++)
        {
            prefab[i].SetActive(false);
        }
        if (load.GetComponent<Player>().skin - 1 >= 0)
        {
            prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
        }
        //prefab[load.GetComponent<Player>().skin - 1].SetActive(true);
    }
    public void skin_0()
    {
        load.GetComponent<Player>().skin = 0;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_1() {
        load.GetComponent<Player>().skin = 1;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_2()
    {
        load.GetComponent<Player>().skin = 2;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_3()
    {
        load.GetComponent<Player>().skin = 3;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_4()
    {
        load.GetComponent<Player>().skin = 4;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_5()
    {
        load.GetComponent<Player>().skin = 5;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_6()
    {
        load.GetComponent<Player>().skin = 6;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_7()
    {
        load.GetComponent<Player>().skin = 7;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_8()
    {
        load.GetComponent<Player>().skin = 8;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_9()
    {
        load.GetComponent<Player>().skin = 9;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_10()
    {
        load.GetComponent<Player>().skin = 10;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_11()
    {
        load.GetComponent<Player>().skin = 11;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_12()
    {
        load.GetComponent<Player>().skin = 12;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_13()
    {
        load.GetComponent<Player>().skin = 13;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_14()
    {
        load.GetComponent<Player>().skin = 14;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_15()
    {
        load.GetComponent<Player>().skin = 15;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_16()
    {
        load.GetComponent<Player>().skin = 16;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void skin_17()
    {
        load.GetComponent<Player>().skin = 17;
        chooseSkin();
        load.GetComponent<Player>().SavePlayer();
    }
    public void chooseSkin()
    {
        if (selectedSkin.Length > 0)
        {
            for (int i = 0; i < selectedSkin.Length; i++)
            {
                selectedSkin[i].SetActive(false);
            }
            selectedSkin[load.GetComponent<Player>().skin].SetActive(true);
        }
    }
}
