using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausebuttonusual : MonoBehaviour{
    
    public GameObject usualButton;
    // Start is called before the first frame update
    void Start(){
        usualButton.SetActive(true);
    }
    public void pressed(){
        usualButton.SetActive(false);
        Time.timeScale = 0f;
    }
    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
