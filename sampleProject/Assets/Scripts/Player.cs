using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool[] man = new bool [17];
    public bool[] woman = new bool[13];


    public void winLevel (int num)
    {
        man[num] = true;
    }
    public void unlockSkin(int num)
    {
        woman[num] = true;
    }

    public void SavePlayer ()
    {
        Debug.Log("saved");
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer ()
    {
        playerData data = SaveSystem.LoadPlayer();

        for (int i = 0; i < data.levels.Length; i++)
        {
            Debug.Log(data.levels[i]);
        }

        Debug.Log("load");
        for (int i = 0; i < data.levels.Length; i++)
        {
            man[i] = data.levels[i];
        }
        for (int i = 0; i < data.skins.Length; i++)
        {
            woman[i] = data.skins[i];
        }
    }
}
