using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 target;
    public bool first = true;

    // Update is called once per frame
    void Update()
    {
        if (first)
        {
            target = new Vector2(400, -400);
            rb.velocity = target;
            first = false;
        }
    }
}
