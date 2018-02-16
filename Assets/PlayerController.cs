using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour {
	public float moveSpeed = 0.01f; 

	public KeyCode rightKey = KeyCode.RightArrow; 
	public KeyCode leftKey = KeyCode.LeftArrow; 

	private int score; 
	public Text scoreText; 

	public float bottomOfScreen = -3.0f; 
	public bool restart; 

	private AudioSource source;
	public AudioClip dropSound;

	private Image smokeImg; 

	void Start () { 

		score = 0; 
		SetScoreText ();  

	}

	void Awake () {

		source = GetComponent<AudioSource>();

	}

	void Update () { 

		if (Input.GetKey (rightKey)) {
			transform.Translate (moveSpeed, 0, 0); 
		}

		if (Input.GetKey (leftKey)) { 
			transform.Translate (-moveSpeed, 0, 0); 
		} 

	//	if (gameObject.tag == "Enemy" <= bottomOfScreen) {
	//	if(GameObject.FindGameObjectsWithTag("Enemy") < bottomOfScreen) {
	// 	Debug.Log ("Oh Shit!"); 

	//	} 
			
	} 

	void OnCollisionEnter2D (Collision2D col)
	{ 
		if (col.gameObject.tag == "Enemy") { 

			source.PlayOneShot(dropSound, 0.7f);

			Debug.Log ("boom =" + col.gameObject.name);  
			Destroy (col.gameObject);
			SetScoreText ();  
			score = score + 1; 


		} 

		if (score >= 12) { 
			Debug.Log ("You Won!"); 
			SceneManager.LoadScene ("GameOver"); 
		} 
	} 

	void SetScoreText() {
	
		scoreText.text = "TEARS SAVED: " + score.ToString (); 
	
	} 

}