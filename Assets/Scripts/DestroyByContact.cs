using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{

    public GameObject explosion;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Boundry")
        {
            return;
        }

        Destroy(other.gameObject);
        Destroy(gameObject);

        Instantiate(explosion, transform.position, transform.rotation);

    }
}
