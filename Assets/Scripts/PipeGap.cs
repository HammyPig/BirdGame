using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGap : MonoBehaviour
{
    public LogicManager logicManager;

    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        logicManager.addScore(1);
    }
}
