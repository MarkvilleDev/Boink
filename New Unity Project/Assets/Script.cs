using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Transform player;
    public float speed;
    public Vector3 playerforwardpos;
    public Quaternion playerrot;
    public float forcemultiplier;
    public GameObject explosionEffect;
    public bool doRotation;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerforwardpos = player.forward;
        if (doRotation)
        {
            transform.Rotate(playerforwardpos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(playerforwardpos * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            print("Touched");
            CharacterController controllerenemy = other.gameObject.GetComponent<CharacterController>();
            controllerenemy.Move(playerforwardpos * forcemultiplier);
            Instantiate(explosionEffect, transform.position, transform.rotation);
            explosionEffect.GetComponent<ParticleSystem>().Play();
            Destroy(gameObject);
        }
    }
}
