using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skinSelector : MonoBehaviour
{
    public Image[] lockImages;
    public Button[] skinImage;
    public GameObject load;


    void Start()
    {
        for (int i = 1; i < lockImages.Length; i++)
        {
            skinImage[i].interactable = false;
        }
        load.GetComponent<Player>().LoadPlayer();
        for (int i = 1; i < lockImages.Length; i++)
        {
            if (load.GetComponent<Player>().skins[i])
            {
                lockImages[i].enabled = false;
                skinImage[i].interactable = true;
            }
        }
        load.GetComponent<Player>().SavePlayer();
    }
}
