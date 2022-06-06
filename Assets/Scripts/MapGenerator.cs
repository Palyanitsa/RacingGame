using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public Rigidbody rb_player;
    public GameObject gameObject_mapTile;
    private float PlayerLastZPos = 0;
    public float playerDistance = 1000.0f;
    //GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        rb_player = GameObject.Find("Player").GetComponent<Rigidbody>();

        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPos = new Vector3(0, 0, (i * 79));
            Instantiate(gameObject_mapTile, spawnPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (rb_player.position.z - PlayerLastZPos > 50)
        {
            PlayerLastZPos = rb_player.position.z;
            Vector3 spawnPos = new Vector3(0, 0, rb_player.position.z+300);
            Instantiate(gameObject_mapTile, spawnPos, Quaternion.identity);
            //Destroy(clone, 2.0f);
        }
    }
}
