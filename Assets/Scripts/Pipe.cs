using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5;
    public bool isBobbing = false;
    public GameObject topPipe;
    public GameObject bottomPipe;
    private int bobbingSpeed = 5;
    private float deadZone = -45;
    public float minOffset = -2;
    public float maxOffset = 2;

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

        if (isBobbing) {
            if (transform.position.y >= 6 || transform.position.y <= -6) {
                bobbingSpeed = -bobbingSpeed;
            }

            transform.position = transform.position + (bobbingSpeed*Vector3.up) * Time.deltaTime;
        }
    }
}
