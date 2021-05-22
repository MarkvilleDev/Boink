using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class playerData
{
    public bool[] levels;
    public bool[] skins;

    public playerData (Player player)
    {
        levels = new bool[player.levels.Length];
        skins = new bool[player.skins.Length];

        for (int i=0;i<player.levels.Length; i++)
        {
            levels[i] = player.levels[i];
        }
        for (int i = 0; i < player.skins.Length; i++)
        {
            skins[i] = player.skins[i];
        }
    }

}
