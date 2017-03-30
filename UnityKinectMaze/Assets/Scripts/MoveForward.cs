using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveForward : MonoBehaviour {

	public float forwardspeed = 2.0f;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		setCountText ();
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
			if (count >= 6) {
				winText.text = "You win!";
			}
		}

		if (other.gameObject.CompareTag ("Enemy")) {
			transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
		}

		if (other.gameObject.tag == "Portal") {
			Application.LoadLevel ("WinScene");
		}
	}

	void setCountText(){
		countText.text = "Count: " + count.ToString ();
	}
}
