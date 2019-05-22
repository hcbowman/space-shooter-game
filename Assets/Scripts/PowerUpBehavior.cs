using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour
{
    //public PowerUpController controller;

    [SerializeField]
    private PowerUp powerUp;

    private Renderer renderer_;

    private Transform transform_;

    void Awake()
    {
        transform_ = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ActivayePowerUp();
            gameObject.SetActive(false);
        }
    }

    private void ActivayePowerUp()
    {
        //controller
    }

    public void SetPowerUp(PowerUp powerUp)
    {
        gameObject.name = powerUp.name;
    }
}
