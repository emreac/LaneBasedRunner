using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;

    private void Update()
    {
        if(timeBtwSpawn <= 0)
        {
            Instantiate(coin, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
