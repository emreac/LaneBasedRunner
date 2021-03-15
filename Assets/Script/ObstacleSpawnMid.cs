using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnMid : MonoBehaviour
{
    public GameObject player;

    public GameObject obstacle;
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
            xAxis = Random.Range(player.transform.localPosition.z   , transform.localPosition.z );
            Vector3 pos = new Vector3(-1f, 0.5f, -zAxis + 180f );
            Instantiate(obstacle.transform, pos, Quaternion.identity);
            

            
        }
        
        
    }
   
}
