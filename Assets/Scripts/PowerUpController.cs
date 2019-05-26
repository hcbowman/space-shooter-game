using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{

    public GameObject powerUpPreFab;

    public List<PowerUp> powerUps;

    public Dictionary<PowerUp, float> activePowerUps = new Dictionary<PowerUp, float>();

    private List<PowerUp> keys = new List<PowerUp>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleActivePowerUps();
    }

    public void HandleActivePowerUps()
    {
        bool changed = false;

        if(activePowerUps.Count > 0)
        {
            foreach (PowerUp pwrUp in keys)
            {
                if (activePowerUps[pwrUp] > 0)
                {
                    activePowerUps[pwrUp] -= Time.deltaTime;
                }
                else
                {
                    changed = true;

                    activePowerUps.Remove(pwrUp);

                    pwrUp.End();
                }
            }
        }

        if(changed)
        {
            keys = new List<PowerUp>(activePowerUps.Keys);
        }

    }

    public void ActivatePowerUp(PowerUp pwrUp)
    {
        if (!activePowerUps.ContainsKey(pwrUp))
        {
            pwrUp.Start();
            activePowerUps.Add(pwrUp, pwrUp.duration);
        }
        else
        {
            activePowerUps[pwrUp] += pwrUp.duration;
        }

        keys = new List<PowerUp>(activePowerUps.Keys);
    }

    public GameObject SpawnPowerUp(PowerUp pwrUp, Vector3 position)
    {
        GameObject powerUpGameObject = Instantiate(powerUpPreFab);

        var powerUpBehavior = powerUpGameObject.GetComponent<PowerUpBehavior>();

        powerUpBehavior.controller = this;

        powerUpBehavior.SetPowerUp(pwrUp);

        powerUpGameObject.transform.position = position;


        return powerUpGameObject;
    }

}
