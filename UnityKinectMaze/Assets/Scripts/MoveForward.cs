using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveForward : MonoBehaviour {

	public float forwardspeed = 2.0f;
	public Text countText;
	public Text winText;
	public Text livesText;
	private Vector3 resetPosition;


	private Rigidbody rb;
	private int count;
	private int lives;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		lives = 3;
		setCountText ();
		setLivesText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * forwardspeed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			setCountText ();
		}

		if (other.gameObject.CompareTag ("Enemy")) {
			lives = lives - 1;
			setLivesText ();
			resetPlayer ();
		}

		if (other.gameObject.tag == "Portal") {
			Application.LoadLevel ("WinScene");
		}
	}

	void resetPlayer(){

		if (lives <= 0) {
			Application.LoadLevel ("gameOverScene");
		} else {
			transform.position = resetPosition;
			transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
		}
	}

	void setCountText(){
		countText.text = "Score: " + count.ToString ();
	}

	void setLivesText() {
		livesText.text = "Lives: " + lives.ToString();
	}
}
