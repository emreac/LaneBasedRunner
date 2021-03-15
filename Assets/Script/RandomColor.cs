using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public Color[] ColorBank;

    public bool mesh;

    // Start is called before the first frame update
    void Start()
    {
        int Num = Random.Range(0, ColorBank.Length);
        if (mesh)
        {
            MeshRenderer m = GetComponent<MeshRenderer>();
            m.material.color = ColorBank[Num];
        }



    }

    // Update is called once per frame
    void Update()
    {


    }
}
