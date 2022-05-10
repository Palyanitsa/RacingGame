using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Rigidbody rb_player;
    public List<GameObject> Prefabs;
    public float positionX = 7.0f;
    public float positionZ = 200.0f;
    public float playerDistance = 100.0f;
    public float spawnDistance = 0.0f;
    private float t_time = 0.0f;
    private float timeToSpawn = 1.0f;

    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb_player = GameObject.Find("Player").GetComponent<Rigidbody>();
        t_time += Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        spawnDistance = rb_player.position.z + playerDistance;
        
        if (t_time + timeToSpawn <= Time.time)
        {
            for (int i = 0; i < 4; i++)
            {
                //
                float randPosX = Random.Range(positionX, -positionX);
                float randPosZ = Random.Range(positionZ, -positionZ);
                Vector3 spawnPos = new Vector3(randPosX, 0, spawnDistance + randPosZ);
                int rand = Random.Range(0, Prefabs.Count);
                Instantiate(Prefabs[rand], spawnPos, Quaternion.identity);
                t_time = Time.time;
            }
            
        }


        
    }
}
