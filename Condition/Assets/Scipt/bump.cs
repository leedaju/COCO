using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bump : MonoBehaviour {

	GameObject bear;
	GameObject bear_up;


	// Use this for initialization
	void Start () {
		this.bear = GameObject.Find ("bear");
		this.bear_up = GameObject.Find ("bear_up");

	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (-275.228, -558.345, 0);

		Vector2 p1 = transform.position;
		Vector2 p2 = this.bear.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.2f;
		float r2 = 0.4f;

		if (d < r1 + r2) {
			this.bear.SetActive (false);
			this.bear_up.SetActive (true);
			transform.Translate (0, 0.2f, 0);

		}
	}

}
