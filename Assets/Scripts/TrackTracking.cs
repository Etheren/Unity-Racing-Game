using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTracking : MonoBehaviour {

    public List<RaceCheckpoints> checkpoints;
    public float lapsCompleted;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            
        }
    }
}

[System.Serializable]
public class RaceCheckpoints
{
    public BoxCollider checkpointMesh;
}