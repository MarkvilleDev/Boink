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
        levels = new bool[player.man.Length];
        skins = new bool[player.woman.Length];

        for (int i=0;i<player.man.Length; i++)
        {
            levels[i] = player.man[i];
        }
        for (int i = 0; i < player.woman.Length; i++)
        {
            skins[i] = player.woman[i];
        }
    }

}
