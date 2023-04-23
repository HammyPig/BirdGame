using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicManager logicManager;
    public Transform leftWing;
    public Transform rightWing;
    private bool isDead = false;
    private float bodyRotation = 0;
    private float wingRotation = 0;

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
        updateBirdWing();
    }

    void updateRotation() {
        bodyRotation = myRigidbody.velocity.y + 5;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, bodyRotation);
    }

    void updateBirdWing() {
        wingRotation = 2 * myRigidbody.velocity.y + 30;
        leftWing.transform.rotation = Quaternion.Euler(leftWing.transform.rotation.x, leftWing.transform.rotation.y, leftWing.transform.rotation.z - wingRotation);
        rightWing.transform.rotation = Quaternion.Euler(rightWing.transform.rotation.x, rightWing.transform.rotation.y, rightWing.transform.rotation.z + wingRotation);
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        logicManager.gameOver();
        isDead = true;
    }
}
