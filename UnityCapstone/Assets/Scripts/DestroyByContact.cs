using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    //reference to explosion visual effect
    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        //asteroid explosion
        Instantiate(explosion, transform.position, transform.rotation);
        //player explosion, if hit by asteroid
        if (other.tag == "Player") {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            //gameController.GameOver();
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
