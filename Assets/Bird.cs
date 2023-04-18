using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicManager logicManager;
    private bool isDead = false;

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
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        logicManager.gameOver();
        isDead = true;
    }
}
