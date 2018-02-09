using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseScript : MonoBehaviour {

	// Use this for initialization
	void Start () {


		
	}
	
	void OnCollisionEnter2D (Collision2D col)
	{ 
		if (col.gameObject.tag == "Enemy") { 

			Debug.Log ("HI" + col.gameObject.name);
			Destroy (col.gameObject);
			SceneManager.LoadScene ("Lose"); 


		}

	}
}