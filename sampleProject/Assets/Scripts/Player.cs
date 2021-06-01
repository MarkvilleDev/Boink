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
        LoadPlayer();
    }

    public void winLevel (int num)
    {
        LoadPlayer();
        levels[num+1] = true;
        skins[num] = true;
        SavePlayer();
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
        levels = data.levels;
        skins = data.skins;

        Debug.Log(levels.Length);
        Debug.Log(skins.Length);
        for (int i = 0; i < data.levels.Length; i++)
        { 
            levels[i] = data.levels[i];
        }
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
