using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicClass : pausecomp 
{
    private AudioSource _audioSource;
    private GameObject[] other;
    private bool NotFirst = false;
    private void Awake()
    {
        other = GameObject.FindGameObjectsWithTag("Music");

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
        _audioSource = GetComponent<AudioSource>();
    }
    private void Update() 
    {
        // why doesnt this work????
        if (paused)
        {
            Debug.Log("hi");
            _audioSource.volume = 0f;
        } else 
        {
            // Debug.Log("updating");
            _audioSource.volume = 1f;
        }
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
