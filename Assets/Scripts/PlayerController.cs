using UnityEngine;
using System.Collections;


[System.Serializable]
public class Boundry
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float tilt;
    public Boundry shipBoundries;

    public GameObject ammoType;
    public Transform shotSpawn;

    public float fireRate;
    private float nextShot;


    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextShot)
        {
            nextShot = Time.time + fireRate;

            Instantiate(ammoType, shotSpawn.position, shotSpawn.rotation);

        }
    }


    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().velocity = movement * speed;

        GetComponent<Rigidbody>().position = new Vector3(Mathf.Clamp(GetComponent<Rigidbody>().position.x, shipBoundries.xMin, shipBoundries.xMax),
                                                         0.0f,
                                                         Mathf.Clamp(GetComponent<Rigidbody>().position.z, shipBoundries.zMin, shipBoundries.zMax));

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);



    }
    

}
