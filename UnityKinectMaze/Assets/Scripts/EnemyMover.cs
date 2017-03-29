using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour {

	public float speed = 3;
	public float startingX;
	public float targetX;
	public float direction;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (direction * Mathf.PingPong (Time.time * speed, targetX * 2) + startingX * direction, transform.position.y, transform.position.z);
	}
}
