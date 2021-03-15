using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartıcleMove : MonoBehaviour
{
    public float movementSpeed;


    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
    }
}
