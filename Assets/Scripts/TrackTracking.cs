using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTracking : MonoBehaviour {

    public List<RaceCheckpoints> checkpoints;
    public float lapsCompleted;

    void OnTriggerEnter (Collider col)
    {

    }

}

[System.Serializable]
public class RaceCheckpoints
{
    public BoxCollider checkpointMesh;
}