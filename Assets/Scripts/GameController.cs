using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;


    // Start is called before the first frame update
    void Start()
    {
        SpawnWaves();
    }

    void SpawnWaves()
    {

        while(true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotaion = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotaion);
            }
        }

    }

}
