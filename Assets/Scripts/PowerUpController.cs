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
        
    }

    public GameObject SpawnPowerUp(PowerUp pwrUp, Vector3 position)
    {
        GameObject powerUpGameObject = Instantiate(powerUpPreFab);

        //var powerUpBehavior = powerUpGameObject.GetComponent<>(PowerUpBehavior);

        return powerUpGameObject;
    }

}
