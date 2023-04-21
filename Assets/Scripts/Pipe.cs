using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5;
    private float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (moveSpeed*Vector3.left) * Time.deltaTime;

        if (transform.position.x <= deadZone) {
            Destroy(gameObject);
        }
    }
}
