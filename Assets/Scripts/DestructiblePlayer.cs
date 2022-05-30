using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructiblePlayer : MonoBehaviour
{
    public GameObject destroyedVersion;
   
    
    //void OnMouseDown()
    // {
    //     Instantiate(destroyedVersion, transform.position, transform.rotation);
    //     Destroy(gameObject);
    // } 

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
