using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicManager logicManager;
    private bool isDead = false;
    private float rotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Bird";
    }

    // Update is called once per frame
    void Update()
    {   
        if (isDead) { return; }

        if (Input.GetKeyDown(KeyCode.Space) == true) {
            myRigidbody.velocity = flapStrength * Vector2.up;
        }

        updateRotation();
    }

    void updateRotation() {
        rotation = myRigidbody.velocity.y + 5;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        logicManager.gameOver();
        isDead = true;
    }
}
