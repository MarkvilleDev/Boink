using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backGroundscaler : MonoBehaviour
{
    void Start()
    {
        float height = screenSize.GetScreenToWorldHeight;
        transform.localScale = Vector3.one * height;
    }
}
