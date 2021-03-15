using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    

    public int coinValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            CoinCounter.instance.ChangeScore(coinValue);
            this.gameObject.SetActive(false);
           
        }
     
    }



}
