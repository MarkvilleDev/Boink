using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool[] levels;
    public bool[] skins;
    public bool ismuted;
    public int skin;

    public void Start()
    {
        LoadPlayer();
        Time.timeScale=1f;
        //for (int i = 0; i < levels.Length; i++)
        //{
        //    levels[i] = false;
        //}
        //for (int i = 0; i < skins.Length; i++)
        //{
        //    skins[i] = false;
        //}
        //skin = 0;
        SavePlayer();
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
        ismuted = data.ismuted;
        levels = data.levels;
        skins = data.skins;
        skin = data.skin;

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
