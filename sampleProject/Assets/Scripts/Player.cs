using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool[] man;
    public bool[] woman;

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
        man = new bool[22];
        woman = new bool[22];

        for (int i = 0; i < data.levels.Length; i++)
        {
            Debug.Log(data.levels[i]);
        }

        Debug.Log("load");
        for (int i = 0; i < data.levels.Length; i++)
        {
            man[i] = data.levels[i];
            Debug.Log("data " + data.levels[i]);
            Debug.Log("man " + man[i]);
        }
        for (int i = 0; i < data.skins.Length; i++)
        {
            woman[i] = data.skins[i];
        }
    }
}
