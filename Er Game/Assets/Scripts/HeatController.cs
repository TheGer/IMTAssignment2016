﻿using UnityEngine;
using System.Collections;

public class HeatController : MonoBehaviour {

	float speed;

	// Use this for initialization
	void Start () {
		//speed number 3
		speed = 3f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate 
			(Vector3.down * speed * Time.deltaTime);

		if (transform.position.y < -10) {
			//delete the heart
			Destroy(this.gameObject);
		}
	}
}
