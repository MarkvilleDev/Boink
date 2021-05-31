using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool[] levels;
    public bool[] skins;
    public int test;
    public int test2;
    public bool ismuted;

    public void Start()
    {
        //just some code to reset things
        for (int i = 0; i < levels.Length; i++)
        {
            levels[i] = false;
            SavePlayer();
        }
    }

    public void winLevel (int num)
    {
        LoadPlayer();
        levels[num+1] = true;
        SavePlayer();
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
        ismuted = data.ismuted;

        Debug.Log("load");
        for (int i = 0; i < data.levels.Length; i++)
        {
            levels[i] = data.levels[i];
        }

        Debug.Log(test);
        Debug.Log(test2);
        for (int i = 0; i < data.skins.Length; i++)
        {
            skins[i] = data.skins[i];
        }
    }
    public void mute()
    {
        ismuted = true;
        SavePlayer();
        LoadPlayer();
    }
    public void unmute()
    {
        ismuted = false;
        SavePlayer();
        LoadPlayer();
    }
}
