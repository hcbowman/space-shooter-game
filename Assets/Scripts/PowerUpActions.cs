using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpActions : MonoBehaviour
{

    public PlayerController playerController;

    public void HighSpeedStartAction()
    {
        playerController.speed *= 2;
    }

    public void HighSpeedEndAction()
    {
        playerController.speed = 2;
    }

}
