using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public GameObject track;
    public bool spawned;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !spawned)
        {
            Vector3 pos = new Vector3(transform.parent.position.x , (transform.parent.position.y), transform.parent.position.z + 900f);
            Instantiate(track.transform, pos, transform.parent.rotation);
            spawned = true;
        }
    }


}
