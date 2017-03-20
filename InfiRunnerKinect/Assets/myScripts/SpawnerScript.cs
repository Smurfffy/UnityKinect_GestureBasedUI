using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

	public List platformList;
	public List platformTypes;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 6; i++) {
			GameObject x = (GameObject)GameObject.Instantiate (this.PathPlatforms [0], new Vector3 (0, -3f, 0), Quaternion.identity);
			x.tag = bottomPlatformTag;
			x.gameObject.tag = "Platform";
			this.activeBottomPlatforms.Add (x);
		}	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
