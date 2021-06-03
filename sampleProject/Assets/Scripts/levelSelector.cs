using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelSelector : MonoBehaviour
{
    public Image[] lockImages;
    public Button[] lvlButtons;
    public GameObject load;
    
    void Start()
    {
        load.GetComponent<Player>().SavePlayer();

        for (int i = 1; i < lockImages.Length; i++)
        {
            lvlButtons[i].interactable = false;
        }
        load.GetComponent<Player>().LoadPlayer();
        for (int i = 1; i < lockImages.Length; i++) {
            if (load.GetComponent<Player>().levels[i]) {
                lockImages[i].enabled = false;
                lvlButtons[i].interactable = true;
            }
        }
        load.GetComponent<Player>().SavePlayer();
    }
}
