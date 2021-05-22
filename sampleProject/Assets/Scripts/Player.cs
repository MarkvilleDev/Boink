using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool[] levels = new bool [17];
    public bool[] skins = new bool [13];
    public int test;
    public int test2;

    public void winLevel (int num)
    {
        levels[num] = true;
    }
    public void unlockSkin(int num)
    {
        skins[num] = true;
    }

    public void SavePlayer ()
    {
        Debug.Log("saved");
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer ()
    {
        playerData data = SaveSystem.LoadPlayer();
        test = data.levels.Length;
        test2 = data.skins.Length;

        //for (int i = 0; i < data.levels.Length; i++)
        //{
        //    Debug.Log(data.levels[i]);
        //}

        Debug.Log("load");
        for (int i = 0; i < data.levels.Length; i++)
        {
            levels[i] = data.levels[i];
            //Debug.Log("data " + data.levels[i]);
            //Debug.Log("man " + man[i]);
        }

        Debug.Log(test);
        Debug.Log(test2);
        for (int i = 0; i < data.skins.Length; i++)
        {
            skins[i] = data.skins[i];
        }
    }

    public void Update()
    {
        
    }
}
