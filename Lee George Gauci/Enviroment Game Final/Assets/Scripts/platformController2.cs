using UnityEngine;
using System.Collections;

public class platformController2 : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		speed = 10;
	}

	void Update () {
		transform.Translate (0, -speed * (Time.deltaTime / 2) , 0);

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("botLimit")) {
			speed = speed - (speed * 2);
		}

		if (other.gameObject.CompareTag ("topLimit")) {

			speed = speed + (-speed * 2);
		}
	}
}
