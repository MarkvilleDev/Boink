using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingscript : MonoBehaviour
{
    public GameObject throwProjectile;
    public float speed = 5f;
    public float force;
    public LayerMask mask;
    public ParticleSystem muzzleFlash;
    public Transform ParticleHolder;
    private GameObject instantiatedparticle;
    public float amountofDelay;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            instantiatedparticle = Instantiate(muzzleFlash.gameObject, ParticleHolder.position, transform.rotation);
            
            destroyobject(instantiatedparticle); // this muzzleFlash needs to be destroyed but can't
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit, mask))
            {
                print(hit + "Something you hit");
                
            }
            //Instantiate(throwProjectile,transform.position, Quaternion.identity);
        }
        
    }
    public void destroyobject(GameObject gameObject)
    {
        enumerator(gameObject);
    }
    IEnumerator enumerator(GameObject game)
    {
        yield return new WaitForSeconds(amountofDelay);
        Destroy(game);
    }
}
