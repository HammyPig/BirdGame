using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float maxSpawnOffset = 10;

    // Start is called before the first frame update
    void Start() {
        spawnPipe();
    }

    // Update is called once per frame
    void Update() {   
        if (timer >= spawnRate) {
            spawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void spawnPipe() {
        Instantiate(
            pipe,
            new Vector3(
                transform.position.x,
                transform.position.y + Random.Range(-maxSpawnOffset, maxSpawnOffset),
                transform.position.z
            ),
            transform.rotation
        );
    }
}
