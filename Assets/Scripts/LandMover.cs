using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandMover : MonoBehaviour
{
    public GameObject player;
    private Transform tf;

    private void Start()
    {
        tf = gameObject.transform;
    }

    void FixedUpdate()
    {
        tf.position = new Vector3(tf.position.x, tf.position.y, player.transform.position.z);
    }
}
