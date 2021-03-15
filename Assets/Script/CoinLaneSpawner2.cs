﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLaneSpawner2 : MonoBehaviour
{
    public GameObject player;

    public GameObject coin;
    public float amountOfLantern;

    public float minX, maxX;

    public void Start()
    {
        player = GameObject.FindWithTag("Player");

        for (int i = 0; i < amountOfLantern; i++)
        {

            float xAxis, zAxis;

            zAxis = Random.Range(minX, maxX);
            // yAxis = Random.Range(player.transform.localPosition.x - 20, player.transform.localPosition.x - 100);
            xAxis = Random.Range(player.transform.localPosition.x -20   , transform.localPosition.x- 100 );
            Vector3 pos = new Vector3(xAxis+60f, 0.6f, -zAxis + 50f );
            Instantiate(coin.transform, pos, transform.rotation * Quaternion.Euler(45, 0, 0));



        }
        
        
    }


   
}
