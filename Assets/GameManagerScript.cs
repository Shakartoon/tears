using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour {

	public GameObject tearPrefab; 
	public Transform[] spawnPoints; 
	public float spawnFrequency; 
	private float timeSinceLastSpawn; 

	public float timeLeft = 1.0f; 

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

		TearSpawning (); 

		timeLeft -= Time.deltaTime;
		if ( timeLeft <= 0.0f )
		{
			SceneManager.LoadScene ("GameOver"); 
			Debug.Log ("bullshit."); 
		}

		
		
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
