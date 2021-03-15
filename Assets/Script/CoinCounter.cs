using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinCounter : MonoBehaviour
{

    public float movementSpeed;
    public static CoinCounter instance;
    public Text text;
    public int coinScore;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    // Update is called once per frame
    void Update()
    {



    }

    public void ChangeScore(int coinValue)
    {
        coinScore += coinValue;
        text.text = "" + coinScore.ToString();

    }
}


