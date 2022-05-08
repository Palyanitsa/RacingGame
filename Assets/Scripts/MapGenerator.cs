using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public Rigidbody rb_player;
    public GameObject gameObject_mapTile;

    public float playerDistance = 1000.0f;
    public float spawnDistance = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb_player = GameObject.Find("Player").GetComponent<Rigidbody>();

        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPos = new Vector3(0.0f, 0, spawnDistance + (i * 79));
            Instantiate(gameObject_mapTile, spawnPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnDistance = rb_player.position.z + playerDistance;

        if (rb_player.position.z % 100 == 0)
        {
            Vector3 spawnPos = new Vector3(0.0f, rb_player.position.y, spawnDistance);
            Instantiate(gameObject_mapTile, spawnPos, Quaternion.identity);
        }
    }
}
