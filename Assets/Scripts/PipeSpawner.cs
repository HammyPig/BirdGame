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
        GameObject newPipe = Instantiate(
            pipe,
            new Vector3(
                transform.position.x,
                transform.position.y + Random.Range(-maxSpawnOffset, maxSpawnOffset),
                transform.position.z
            ),
            transform.rotation
        );

        Pipe p = newPipe.GetComponent<Pipe>();
        
        float randomValue = Random.value;
        if (randomValue < 0.5) {
            p.isBobbing = true;
        } else {
            p.isBobbing = false;
        }
        
        float randomOffset = Random.Range(p.minOffset, p.maxOffset);
        p.topPipe.transform.position = new Vector3(
            p.topPipe.transform.position.x,
            p.topPipe.transform.position.y + randomOffset,
            p.topPipe.transform.position.z
        );

        randomOffset = Random.Range(p.minOffset, p.maxOffset);
        p.bottomPipe.transform.position = new Vector3(
            p.bottomPipe.transform.position.x,
            p.bottomPipe.transform.position.y + randomOffset,
            p.bottomPipe.transform.position.z
        );
    }
}
