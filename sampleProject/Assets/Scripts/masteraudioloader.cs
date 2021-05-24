using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masteraudioloader : MonoBehaviour
{
    private GameObject[] other;
    private bool NotFirst = false;

    private void Awake()
    {
        other = GameObject.FindGameObjectsWithTag("masteraudio");
        foreach (GameObject oneOther in other)
        {
            if (oneOther.scene.buildIndex == -1)
            {
                NotFirst = true;
            }
        }

        if (NotFirst == true)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(transform.gameObject);
    }
}
