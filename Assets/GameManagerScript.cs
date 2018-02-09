using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

	public GameObject tearPrefab; 
	public Transform[] spawnPoints; 
	public float spawnFrequency; 
	private float timeSinceLastSpawn; 

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

		TearSpawning (); 
		
		
	}

	void TearSpawning () {

		timeSinceLastSpawn += Time.deltaTime; 

		if (timeSinceLastSpawn >= spawnFrequency) {
		
			SpawnTear (); 
			timeSinceLastSpawn = 0; 

		}
	
	
	} 

	void SpawnTear () {

		int spawnIndex = Random.Range (0, spawnPoints.Length); 


		Transform spawnTransform = spawnPoints [spawnIndex]; 
		Vector3 spawnLocation = spawnTransform.position; 

		GameObject tear = Instantiate (tearPrefab, spawnLocation, Quaternion.identity);  

	} 

}
