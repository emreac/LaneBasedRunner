using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBoost : MonoBehaviour
{
    public Player player;
    public float speed;


    public int coinValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            player.speed = 17f;
      //  CoinCounter.instance.ChangeScore(coinValue);
             this.gameObject.SetActive(false);
            Invoke("speedBoosterNormal", 10);
        }
     
    }
    public void speedBoosterNormal()
    {

        player.speed = 7f;




    }


}
