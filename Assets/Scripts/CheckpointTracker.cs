using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTracker : MonoBehaviour {

    public bool isStartFinish;
    public bool isCheckpoint;
    public bool hasPassed;

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Checkpoint2");
            hasPassed = true;
        }
    }
}
