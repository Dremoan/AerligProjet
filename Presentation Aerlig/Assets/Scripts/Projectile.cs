using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [Range(0, 100)]
    public float speed;


    void Update ()
    {
        transform.position += transform.up * -speed;
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Water")
        {
            Destroy(gameObject);
        }
    }

}
