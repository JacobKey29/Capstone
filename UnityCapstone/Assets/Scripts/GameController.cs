using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject hazard;
    public Vector3 spawnValues;

    // Use this for initialization
    void Start () {
        SpawnWaves();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnWaves() {
        //Randomly spawn the asteroid along the x plane
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
        //give the asteroid rotation
        Quaternion spawnRotation = Quaternion.identity;
        //create
        Instantiate(hazard, spawnPosition, spawnRotation);
    }
}
